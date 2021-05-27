'use strict';

$(document).ready(function () {
    //4 cards in a row
    $('#cards-group-four').owlCarousel({
        lazyLoad: true,
        loop: true,
        margin: 10,
        nav: false,
        dots: true,
        autoplay: true,

        responsive: {
            0: {
                items: 1

            },
            576: {
                items: 1
            },
            768: {
                items: 2
            },
            990: {
                items: 4
            }
        }
    });
});

