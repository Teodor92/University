(function () {

    if ($.cookie("language") === "en") {
        $("#bg").removeClass("active-language");
        $("#en").addClass("active-language");
    } else {
        $("#bg").addClass("active-language");
        $("#en").removeClass("active-language");
    }

    $(".language").click(function (n) {
        $.cookie("language", $(n.target).data("lang"), {
            expires: 7,
            path: "/"
        });
        window.location.reload();
    });

}());