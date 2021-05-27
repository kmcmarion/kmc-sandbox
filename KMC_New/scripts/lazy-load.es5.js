"use strict";

var images = document.querySelectorAll("[data-src]");
var bgImages = document.querySelectorAll("[data-background]");

function preloadImage(img) {
    var src = img.getAttribute("data-src");
    if (!src) {
        return;
    }
    img.src = src;
}

function preloadBgImage(div) {
    var background = div.getAttribute("data-background");
    if (!background) {
        return;
    }
    div.background = background;
}

var imgOptions = {
    threshold: 0,
    opacity: 0
};

var imgObserver = new IntersectionObserver(function (entries, imgObserver) {
    entries.forEach(function (entry) {
        if (!entry.isIntersecting) {
            return;
        } else {
            preloadImage(entry.target);
            preloadBgImage(entry.target);
            imgObserver.unobserve(entry.target);
            console.log("optimized");
        }
    });
}, imgOptions);

images.forEach(function (image) {
    imgObserver.observe(image);
});

bgImages.forEach(function (div) {
    imgObserver.observe(div);
});

