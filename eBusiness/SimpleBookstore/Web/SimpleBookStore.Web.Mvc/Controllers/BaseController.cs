namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System;
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Web.Script.Serialization;

    using SimpleBookStore.Common;
    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Models;
    using SimpleBookStore.Web.Common;

    public class BaseController : Controller
    {
        public BaseController(ISbsData data)
        {
            this.Data = data;
        }

        public BaseController(ISbsData data, User profile)
            : this(data)
        {
            this.UserProfile = profile;
        }

        protected ISbsData Data { get; set; }

        protected User UserProfile { get; set; }

        protected internal RedirectToRouteResult RedirectToAction<TController>(Expression<Action<TController>> expression)
            where TController : Controller
        {
            var method = expression.Body as MethodCallExpression;
            if (method == null)
            {
                throw new ArgumentException("Expected method call");
            }

            return this.RedirectToAction(method.Method.Name);
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            // Work with data before BeginExecute to prevent "NotSupportedException: A second operation started on this context before a previous asynchronous operation completed."
            this.UserProfile = this.Data.Users.GetByUsername(requestContext.HttpContext.User.Identity.Name);

            // Calling BeginExecute before PrepareSystemMessages for the TempData to has values
            var result = base.BeginExecute(requestContext, callback, state);

            var systemMessages = this.PrepareSystemMessages();
            this.ViewBag.SystemMessages = systemMessages;

            return result;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled)
            {
                return;
            }

            if (this.Request.IsAjaxRequest())
            {
                var exception = filterContext.Exception as HttpException;

                if (exception != null)
                {
                    this.Response.StatusCode = exception.GetHttpCode();
                    this.Response.StatusDescription = exception.Message;
                }
            }
            else
            {
                var controllerName = ControllerContext.RouteData.Values["Controller"].ToString();
                var actionName = ControllerContext.RouteData.Values["Action"].ToString();
                this.View("Error", new HandleErrorInfo(filterContext.Exception, controllerName, actionName)).ExecuteResult(this.ControllerContext);
            }

            filterContext.ExceptionHandled = true;
        }

        /// <summary> 
        /// Creates a JSON object with maximum size. 
        /// </summary> 
        /// <param name="data">JSON data.</param> 
        /// <returns>Returns a JSON as content result.</returns> 
        protected ContentResult LargeJson(object data)
        {
            var serializer = new JavaScriptSerializer { MaxJsonLength = int.MaxValue, RecursionLimit = 100 };

            return new ContentResult
            {
                Content = serializer.Serialize(data),
                ContentType = "application/json",
            };
        }

        private SystemMessageCollection PrepareSystemMessages()
        {
            // Warning: always escape data to prevent XSS
            var messages = new SystemMessageCollection();

            if (this.TempData.ContainsKey(GlobalConstants.InfoMessage))
            {
                messages.Add(this.TempData[GlobalConstants.InfoMessage].ToString(), SystemMessageType.Informational, 1000);
            }

            if (this.TempData.ContainsKey(GlobalConstants.SuccessMessage))
            {
                messages.Add(this.TempData[GlobalConstants.SuccessMessage].ToString(), SystemMessageType.Success, 1000);
            }

            if (this.TempData.ContainsKey(GlobalConstants.WarningMessage))
            {
                messages.Add(this.TempData[GlobalConstants.WarningMessage].ToString(), SystemMessageType.Warning, 1000);
            }

            if (this.TempData.ContainsKey(GlobalConstants.DangerMessage))
            {
                messages.Add(this.TempData[GlobalConstants.DangerMessage].ToString(), SystemMessageType.Error, 1000);
            }

            return messages;
        }

        private void SetUserUiCulture(RequestContext requestContext)
        {
            this.SetUiCultureFromCookie(requestContext);
        }

        private void SetUiCultureFromCookie(RequestContext requestContext)
        {
            if (requestContext.HttpContext.Request.Cookies[GlobalConstants.LanguageCookieName] != null &&
                requestContext.HttpContext.Request.Cookies[GlobalConstants.LanguageCookieName].Value == GlobalConstants.EnglishCultureCookieValue)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(GlobalConstants.EnglishCultureInfoName);
                this.SetLanguageCookie(requestContext, GlobalConstants.EnglishCultureCookieValue);
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(GlobalConstants.BulgarianCultureInfoName);
                this.SetLanguageCookie(requestContext, GlobalConstants.BulgarianCultureCookieValue);
            }
        }

        private void SetLanguageCookie(RequestContext requestContext, string language)
        {
            var languageCookie = new HttpCookie(GlobalConstants.LanguageCookieName, language);
            requestContext.HttpContext.Response.SetCookie(languageCookie);
        }
    }
}