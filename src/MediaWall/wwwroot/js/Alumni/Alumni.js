$(function () {
    var $grid = $(".grid").imagesLoaded(function () {
        $grid = $('.grid').isotope({
            // options...
            itemSelector: '.grid-item',
            layoutMode: 'masonry',
            masonry: {
                columnWidth: 90, //LCD of 180 and 270; The optional widths of the thumbnail images.
                gutter: 12 //1 em gutter
            },
            getSortData: {
                date: function (el) {
                    var strdate = $(el).data("datesort");
                    return new Date(strdate);
                }
            }
        });
    });

    $(".filterlink").click(function (e) {
        e.preventDefault();
        var $this = $(this); //cache this for perf.
        $this.toggleClass("active"); //toggle the active class

        if ($(this).hasClass("active")) { //if active is on then we have to filter.

            //first we have to get the filter values
            var lowYearFilter = $this.data("low-year-filter");
            lowYearFilter = parseInt(lowYearFilter);

            var highYearFilter = $this.data("high-year-filter");
            highYearFilter = parseInt(highYearFilter);
            console.log(lowYearFilter, highYearFilter);

            //If we were going from one filter to another then we have to remove active from them
            $(".filterlink").not($this).removeClass("active");
            if (!isNaN(lowYearFilter) || !isNaN(highYearFilter)) {
                //Filter the grid. 
                $grid.isotope({
                    filter: function () {
                        var datefilter = $(this).data("datesort"); //note $(this) changes scope
                        var dates = new Date(datefilter);
                        var year = dates.getFullYear();

                        if (lowYearFilter > 0) {
                            if (highYearFilter > 0) {
                                return (year >= lowYearFilter && year < highYearFilter);
                            }
                            return (year >= lowYearFilter);
                        }
                        return '*';
                    },
                    sortBy: 'date'
                });
            }
            else
            {  
                $grid.isotope({
                    filter: $(".grid-item[data-alumni=True]"),
                    sortBy: 'date'
                });               
            }
        } else { //if active is off then we have to remove all the filters                    
            $grid.isotope({ filter: '*', sortBy: 'date' });
        }
    });

    $("#datesortbtn").click(function () {
        $grid.isotope({ sortBy: 'date' });
    });

    $("#randomizebtn").click(function () {
        $(this).removeClass('active'); //we don't want the button press state to stick. 

        $grid.isotope('shuffle');
    });

    //On a picture click 
    $(".grid-item figure a").click(function (e) {
        e.preventDefault();
        var href = $(this).attr("href");
        var title = $(this).attr("title");

        $("#imagemodal").find(".modal-title").html(title);
        $("#imagemodal").find("#classimg").attr("src", href).attr("alt", "Alt image");
        $("#imagemodal").modal('show');
    });

    $("#alumnilink").addClass("active");
});