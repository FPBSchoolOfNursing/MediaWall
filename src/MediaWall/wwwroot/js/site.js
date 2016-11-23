// Write your Javascript code.
$(function () {
    $("#menubtn").on("click", function (e) {
        e.preventDefault();
        $("#right-slide-menu").toggleClass("opened");
    });
});