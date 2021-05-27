/// <reference path="abovethefold_carousel.js" />
$(document).ready(function () {
    $(this).scrollTop(0);
    var sync1 = $("#building_sync1");
    var sync2 = $("#building_sync2");
    var slidesPerPage = 4; //globaly define number of elements per page
    var syncedSecondary = true;

    sync1.owlCarousel({
        lazyLoad: true,
        items: 1,
        slideSpeed: 2000,
        nav: true,
        autoplay: true,
        dots: false,
        loop: true,
        responsiveRefreshRate: 200,

    }).on('changed.owl.carousel', syncPosition);

    sync2
        .on('initialized.owl.carousel', function () {
            sync2.find(".owl-item").eq(0).addClass("current");
        })
        .owlCarousel({
            items: slidesPerPage,
            lazyLoad: true,
            margin: 10,
            dots: false,
            nav: true,
            smartSpeed: 200,
            slideSpeed: 500,
            slideBy: slidesPerPage, //alternatively you can slide by 1, this way the active slide will stick to the first item in the second carousel
            responsiveRefreshRate: 100,
            navText: ['<svg width="100%" height="100%" viewBox="0 0 11 20"><path style="fill:none;stroke-width: 1px;stroke: #000;" d="M9.554,1.001l-8.607,8.607l8.607,8.606"/></svg>', '<svg width="100%" height="100%" viewBox="0 0 11 20" version="1.1"><path style="fill:none;stroke-width: 1px;stroke: #000;" d="M1.054,18.214l8.606,-8.606l-8.606,-8.607"/></svg>'],
        }).on('changed.owl.carousel', syncPosition2);

    function syncPosition(el) {
        //if you set loop to false, you have to restore this next line
        //var current = el.item.index;

        //if you disable loop you have to comment this block
        var count = el.item.count - 1;
        var current = Math.round(el.item.index - (el.item.count / 2) - .5);

        if (current < 0) {
            current = count;
        }
        if (current > count) {
            current = 0;
        }

        //end block

        sync2
            .find(".owl-item")
            .removeClass("current")
            .eq(current)
            .addClass("current");
        var onscreen = sync2.find('.owl-item.active').length - 1;
        var start = sync2.find('.owl-item.active').first().index();
        var end = sync2.find('.owl-item.active').last().index();

        if (current > end) {
            sync2.data('owl.carousel').to(current, 100, true);
        }
        if (current < start) {
            sync2.data('owl.carousel').to(current - onscreen, 100, true);
        }
    }

    function syncPosition2(el) {
        if (syncedSecondary) {
            var number = el.item.index;
            sync1.data('owl.carousel').to(number, 100, true);
        }
    }

    sync2.on("click", ".owl-item", function (e) {
        e.preventDefault();
        var number = $(this).index();
        sync1.data('owl.carousel').to(number, 300, true);
    });

    //#buildings_mobile
    $('#buildings_mobile').owlCarousel({
        lazyLoad: true,
        loop: true,
        nav: false,
        dots: false,
        margin: 10,

        responsive: {
            0: {
                items: 1,
                stagePadding: 50
            },
            600: {
                items: 1,
                stagePadding: 50
            }
        }
    });

    //Amenities Carousel
    $('#amenities_Carousel').owlCarousel({
        lazyLoad: true,
        loop: false,
        nav: true,
        dots: false,
        margin: 10,

        responsive: {

            1000: {
                items: 1
            }
        }
    });

    //Amenities Carousel Mobile
    $('#amenities_Carousel_mobile').owlCarousel({
        lazyLoad: true,
        loop: true,
        nav: false,
        dots: false,
        margin: 10,

        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1,
                stagePadding: 50
            }
        }
    });

    $('#neighborhood_Carousel').owlCarousel({
        lazyLoad: true,
        loop: false,
        nav: true,
        dots: false,

        responsive: {

            600: {
                items: 1
            },
            1000: {
                items: 1
            }
        }
    });

    //Neighborhood Carousel Mobile
    $('#neighborhood_Carousel_mobile').owlCarousel({
        lazyLoad: true,
        loop: true,
        nav: false,
        dots: false,
        margin: 10,

        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1,
                stagePadding: 50
            }
        }
    });

    // Smooth Scroll
    //$('a[href*=#]').bind('click', function (e) {
    //    var anchor = $(this);
    //    $('html, body').stop().animate({
    //        scrollTop: $(anchor.attr('href')).offset().top
    //    }, 1000);
    //    e.preventDefault();
    //});

    $('.i-accordion').on('show.bs.collapse', function (n) {
        $(n.target).siblings('.panel-heading').find('.panel-title i').toggleClass('glyphicon glyphicon-angle-up');
    });
    $('.i-accordion').on('hide.bs.collapse', function (n) {
        $(n.target).siblings('.panel-heading').find('.panel-title i').toggleClass('glyphicon glyphicon-angle-down');
    });

    //Nav Locations Filter (6 items)
    $(document).on('click', '#nav-link-locations', function featuredLocation() {
        var location = $(this).attr('value');
        //console.log(location);
        return location;
    });
});

