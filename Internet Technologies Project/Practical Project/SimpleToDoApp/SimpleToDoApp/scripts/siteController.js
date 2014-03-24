﻿$(function () {
    var siteContentContaierId = "#body-content";

    // start page load
    viewsFactory.getTemplate("home").done(function (data) {
        $(siteContentContaierId).html(data);
    });

    // nav pages click load
    $("#navigation-link").on("click", "a", function () {
        var view = $(this).data("view");

        viewsFactory.getTemplate(view).done(function (data) {
            $(siteContentContaierId).html(data);
        }, function(err) {
            console.log(err);
        });
    });
});