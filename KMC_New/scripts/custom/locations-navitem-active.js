$(function () {
    $('nav #locationUl a[href^="/' + location.pathname.split("/")[1] + '"]').addClass('active');
});