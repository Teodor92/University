namespace SimpleBookStore.Web.Mvc.ViewModels.Home
{
    using System.ComponentModel.DataAnnotations;

    using SimpleBookStore.Common;

    public class ContactUsViewModel
    {
        [Display(Name = "До")]
        [Required(ErrorMessage = "Моля попълнете полето")]
        [RegularExpression(GlobalConstants.EmailRegex, ErrorMessage = "Моля въведете валиден имейл адрес")]
        public string To { get; set; }

        [Display(Name = "От")]
        [Required(ErrorMessage = "Моля попълнете полето")]
        [RegularExpression(GlobalConstants.EmailRegex, ErrorMessage = "Моля въведете валиден имейл адрес")]
        public string From { get; set; }

        [Display(Name = "Заглавие")]
        [Required(ErrorMessage = "Моля попълнете полето")]
        public string Title { get; set; }

        [Display(Name = "Съдържание")]
        [Required(ErrorMessage = "Моля попълнете полето")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}