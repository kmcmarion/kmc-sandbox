'use strict';

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

