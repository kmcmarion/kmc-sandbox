//Locations Carousel on Home page
'use strict';

$(document).ready(function () {
    $('#locations_carousel').owlCarousel({
        lazyLoad: true,
        loop: true,
        margin: 0,
        nav: true,
        dots: false,
        autoplay: true,
        autoplayTimeout: 7000,
        autoplayHoverPause: true,

        responsive: {
            0: {
                items: 1,
                stagePadding: 40
            },
            600: {
                items: 1,
                stagePadding: 40
            },
            800: {
                items: 2,
                stagePadding: 60
            },
            1200: {
                items: 3,
                stagePadding: 80
            },
            1400: {
                items: 4,
                stagePadding: 100
            }
        }
    });

    //Carousel On Desktop and Mobile
    $('#trustedBy_carousel').owlCarousel({
        lazyLoad: true,
        loop: true,
        margin: 10,
        nav: false,
        dots: true,
        autoplay: true,

        responsive: {
            0: {
                items: 2

            },
            400: {
                items: 2

            },
            600: {
                items: 3

            },
            990: {
                items: 4
            }
        }
    });

    //Use for card groups on carousel
    $('#cards-group').owlCarousel({
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
                items: 3
            }
        }
    });

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

    //Events Posters on Carousel
    $('#event_carousel').owlCarousel({
        lazyLoad: true,
        loop: true,
        nav: false,
        autoplay: true,
        autoplayTimeout: 8000,
        autoplayHoverPause: true,
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

    $('#peopleBehindKMC_carousel').owlCarousel({
        lazyLoad: true,
        loop: false,
        margin: 10,
        nav: false,
        dots: true,

        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            1000: {
                items: 2
            },
            1200: {
                items: 3
            }
        }

    });

    $('#blogs_carousel').owlCarousel({
        lazyLoad: true,
        loop: false,
        margin: 10,
        nav: false,
        dots: true,

        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 3
            },
            1000: {
                items: 3
            }
        }

    });

    //Use for testimonial on carousel
    $('.testimonial-carousel').owlCarousel({
        lazyLoad: true,
        loop: false,
        margin: 10,
        nav: true,
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
                items: 3
            }
        }
    });

    //Checker to enable and disable Owl Carousel
    if ($(window).width() < 854) {
        startCarousel();
    } else {
        $('#packages-carousel').addClass('off');
    }

    $(window).resize(function () {
        if ($(window).width() < 854) {
            startCarousel();
        } else {
            stopCarousel();
        }
    });

    //coworking, virtual packages carousel
    function startCarousel() {
        $('#packages-carousel').owlCarousel({
            lazyLoad: true,
            loop: true,
            margin: 10,
            nav: false,
            dots: false,

            responsive: {
                0: {
                    items: 1,
                    stagePadding: 50
                },

                600: {
                    items: 1,
                    stagePadding: 100
                },

                900: {
                    items: 3
                }
            }
        });
    }

    function stopCarousel() {
        var owl = $('#packages-carousel');
        owl.trigger('destroy.owl.carousel');
        owl.addClass('off');
    }
});

