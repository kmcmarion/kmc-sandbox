'use strict';

$(document).ready(function () {
    $('#aboveTheFold_carousel').owlCarousel({
        lazyLoad: true,
        loop: true,
        nav: false,
        dots: true,
        autoplay: false,
        slideSpeed: 300,
        paginationSpeed: 400,

        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            1000: {
                items: 1
            }
        }
    });
});

