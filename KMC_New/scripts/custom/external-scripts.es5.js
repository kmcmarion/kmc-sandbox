//service worker support
'use strict';

if ('serviceWorker' in navigator) {
    window.addEventListener('load', function () {
        navigator.serviceWorker.register('../sw_cached_site.js').then(function (reg) {
            return console.log('Service Worker: Registered');
        })['catch'](function (err) {
            return console.log('Service Worker: Error: ' + err);
        });
    });
}

//back to top
var btn = document.getElementById("backToTop");
window.onscroll = function () {
    scrollFunction();
};

function scrollFunction() {
    if (document.body.scrollTop > 20) {
        btn.classList.add("show");
        console.log("scrolling");
    } else {
        btn.classList.remove("show");
        console.log("scrolling");
    }
}

function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}

//kmc url
//if (!window.location.hostname.indexOf('www') && window.location.href.indexOf("localhost") <= -1) {
//    window.location = "https://" + "kmc.solutions" + window.location.pathname + window.location.search;
//}

//Mobile Sidepanel
function openMobileNav() {
    document.getElementById('mobileNav').style.width = '270px';
    document.getElementById('main').style.marginLeft = '-270px';
}

function closeMobileNav() {
    document.getElementById('mobileNav').style.width = '0';
    document.getElementById('main').style.marginLeft = '0';
}

//Lazy Load
var images = document.querySelectorAll("[data-src]");

function preloadImage(img) {
    var src = img.getAttribute("data-src");
    if (!src) {
        return;
    }

    img.src = src;
}

var imgOptions = {
    rootMargin: "0px 0px 200px 0px",
    threshold: 0
};

var imgObserver = new IntersectionObserver(function (entries, imgObserver) {
    entries.forEach(function (entry) {
        if (!entry.isIntersecting) {
            return;
        } else {
            preloadImage(entry.target);
            imgObserver.unobserve(entry.target);
            //console.log("load");
        }
    });
}, imgOptions);

images.forEach(function (image) {
    imgObserver.observe(image);
});

$(document).ready(function () {
    //back to top
    var btn = $('#backToTop');

    $(window).scroll(function () {
        if ($(window).scrollTop() > 300) {
            btn.addClass('show');
        } else {
            btn.removeClass('show');
        }
    });

    btn.on('click', function (e) {
        e.preventDefault();
        $('html, body').animate({ scrollTop: 0 }, '300');
    });

    //Nav Item Active
    $(function () {
        var path = window.location.pathname;
        //console.log(path);
        $('nav a[href="' + path + '"]').closest('a').addClass('active text-semibold');
        //target.addClass('active text-semibold');  
    });

    //Featured Locations - 4 items
    $('.location-filter-4').click(function () {
        $('.location-filter-4').removeClass('active');
        $(this).addClass('active');
        $('.all-4').show();
        var locationClass = $(this).attr('data-value');
        $('.all-4').hide();
        $('.' + locationClass).slice(0, 4).show();
    });

    $(function () {
        $(".location-item-4").slice(0, 4).show(); // select the first ten
        $("#load").click(function (e) {
            // click event for load more
            e.preventDefault();
            $(".location-item-4:hidden").slice(0, 4).fadeIn(2000); // select next 10 hidden divs and show them
            if ($(".location-item-4:hidden").length === 0) {// check if any hidden divs still exist           
            }
        });
    });

    //Featured Locations - 6 items
    $('.location-filter-6').click(function () {
        $('.location-filter-6').removeClass('active');
        $(this).addClass('active');
        $('.all-6').show();
        var locationClass = $(this).attr('data-value');
        $('.all-6').hide();
        $('.' + locationClass).slice(0, 6).show();
    });

    $(function () {
        $(".location-item-6").slice(0, 6).show(); // select the first ten
        $("#load").click(function (e) {
            // click event for load more
            e.preventDefault();
            $(".location-item-6:hidden").slice(0, 6).fadeIn(2000); // select next 10 hidden divs and show them
            if ($(".location-item-6:hidden").length === 0) {// check if any hidden divs still exist             
            }
        });
    });

    //All Coworking Spaces
    $(document).ready(function () {
        $('.all-coworking-locations').click(function () {
            $('.all-coworking-locations').removeClass('active');
            $(this).addClass('active');
            $('.all-coworking').show();
            var locationClass = $(this).attr('data-value');
            $('.all-coworking').hide();
            $('.' + locationClass).show();
        });
    });
});

