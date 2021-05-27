"use strict";

var images = document.querySelectorAll("[data-src]");

function preloadImage(img) {
    var src = img.getAttribute("data-src");
    if (!src) {
        return;
    }

    img.src = src;
}

var imgOptions = {
    rootMargin: '0px',
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

