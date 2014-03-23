window.viewsFactory = (function () {
    var rootUrl = "partials/";

    var templates = {};

    function getTemplate(name) {

        var deferred = Q.defer();
        jQuery.support.cors = true;

        if (templates[name]) {
            deferred.resolve(templates[name]);
        }
        else {
            $.ajax({
                url: rootUrl + name + ".html",
                type: "GET",
                success: function (templateHtml) {
                    templates[name] = templateHtml;
                    deferred.resolve(templateHtml);
                },
                error: function (err) {
                    deferred.reject(err);
                }
            });
        }

        return deferred.promise;
    }

    return {
        getTemplate: getTemplate
    };
}());