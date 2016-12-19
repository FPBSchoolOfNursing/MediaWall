var canvas;
var maptimer;

function CloseDialog() {
    $("#mapmodal").modal("hide"); //close our dialog box
    $("html, body").animate({ scrollTop: 0 }, "slow");
}

$(function () {
    $("#directorylink").addClass("active"); //make the menu link active

    $("#directory-table tbody tr").hover(function () { //add hover effect for jquery ui
        $(this).addClass("ui-state-hover");
    }, function () {
        $(this).removeClass("ui-state-hover");
    });

    $("#directory-table tbody tr").click(function () { //show map to persons locattion
        var officeno = $(this).find("td:eq(2)").text(); //get the office number from the table.
        //debuging tests.
        // officeno = "NOA44H";
        DrawMap("Elevator", officeno, Directory.MapPath); //change office no to be whatever you want to trace a specific path. MapPath is a global var declared on the page.
        clearTimeout(maptimer); //clear the auto closing timer.

        $("#mapmodal .modal-title").text("Location of " + officeno);
        $("#mapmodal").modal('show');

        maptimer = setTimeout(CloseDialog, 6e4); //close the dialog box after 1 minute of inactivity.
    });

    $(".filterdir").click(function (e) {
        e.preventDefault();
        $(this).addClass('active'); //make the link active
        $(".filterdir").not($(this)).removeClass("active"); //remove all the other active links

        var filter = $(this).data("filter"); //find what to filter on       

        if (filter != "All") { //if it's not everyone, then selectively show
            $("#table-header").text(filter);
            $("#directory-table tbody").fadeOut(function () { // you have to hide the tbody or the tds. Hiding trs causes issues since they aren't block elements.
                $("#directory-table tbody tr[data-persontype!=" + filter + "]").hide(); //this should cause some race conditions but it's so fast it can't be seen..
                $("#directory-table tbody tr[data-persontype=" + filter + "]").show();
                $(this).fadeIn();
            });
        }
        else //just show everyone
        {
            $("#table-header").text("Directory");
            $("#directory-table tbody").fadeOut(function () { //fade the table body
                $("#directory-table tbody tr").show(); //show everything
                $(this).fadeIn(); //fade the table body back in.
            });
        }
    });
});