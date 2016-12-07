//http://stackoverflow.com/questions/2155453/jquery-toggle-text
jQuery.fn.extend({
    toggleText: function (a, b) {
        var that = this;
        if (that.text() != a && that.text() != b) {
            that.text(a);
        }
        else
            if (that.text() == a) {
                that.text(b);
            }
            else
                if (that.text() == b) {
                    that.text(a);
                }
        return this;
    }
});

var overlay = "#event-overlay";

$(function () {
    $(".menu-toggle").on("click", function (e) {
        e.preventDefault();
        $("#right-slide-menu").toggleClass("opened"); //open the side menu
        
        $(".menu-toggle.menu-action-link") //give some emphasis to the menu button.
            .toggleClass("active")
            .toggleText("Close Menu", "Open Menu"); //Uses the above function extension.

        if ($("#event-overlay").is(':visible')) {
            $("#event-overlay").fadeToggle();
        }
    });

    $("#overlaybtn").on("click", function (e) {
        setOverlayHeight(overlay);
        $(overlay).fadeToggle();
    });

    $("#event-overlay").click(function (e) {
        e.preventDefault();
        $("#event-overlay").fadeToggle();
    });    

    $(window).resize(function () {
        if($("#event-overlay").is(':visible'))
        {
            setOverlayHeight(overlay);           
        }
    });
});

function setOverlayHeight(overlayDiv)
{
    var overlayheight = $(window).height() - $(".navbar-fixed-bottom").outerHeight();
    $(overlayDiv).height(overlayheight);
}
