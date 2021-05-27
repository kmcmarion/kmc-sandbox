'use strict';

$(function () {
    var path = window.location.pathname;
    var target = $('nav a[href="' + path + '"]');
    target.addClass('active text-semibold');
})

