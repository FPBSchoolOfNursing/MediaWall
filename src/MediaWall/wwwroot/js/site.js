// Write your Javascript code.
$(function () {
    $(".menu-toggle").on("click", function (e) {
        e.preventDefault();
        $("#right-slide-menu").toggleClass("opened");
    });
});