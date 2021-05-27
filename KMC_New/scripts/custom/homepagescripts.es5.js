//ES6
"use strict";

$(document).ready(function () {
    //KV Search Form on Desktop
    $("#searchLocationForm").on('submit', function (e) {
        e.preventDefault();
        var x = document.getElementById("building-field");
        var selectedBuilding = $('#building-field').children("option:selected").val();
        window.location.href = selectedBuilding;
    });

    $("#searchPeopleForm").on('submit', function (e) {
        e.preventDefault();
        var x = document.getElementById("people-field");
        var selectedServices = $('#people-field').children("option:selected").val();
        window.location.href = selectedServices;
    });

    //KV Search Form on Mobile
    $("#mobile-kv_search").on('submit', function (e) {
        e.preventDefault();
        var x = document.getElementById("mobile-location-field");
        var selectedLocationMobile = x.options[x.selectedIndex].value;
        window.location.href = selectedLocationMobile;
    });

    //Modal Stop Video
    $('.video-modal').on('hidden.bs.modal', function () {
        var youtubeFrame = $(this).find('.youtube');
        var closeModal = $(this).find('.close-modal');

        console.log('activated', youtubeFrame, closeModal);

        youtubeFrame.attr('src', '');
        youtubeFrame.attr('src', closeModal.attr('data-video-src'));
    });

    $('#video-target').on('hidden.bs.modal', function () {
        $('#youtube').attr('src', '');
        $('#youtube').attr('src', $('#closemodal1').attr('data-video-src'));
    });

    //Modal Auto Play
    $('.video-modal').on('show.bs.modal', function () {
        var youtubeFrame = $(this).find('.youtube');

        var ytSRC = youtubeFrame.attr('src') + '&autoplay=1';

        console.log('auto play', ytSRC);

        youtubeFrame.attr('src', ytSRC);
    });

    $('#video-target').on('show.bs.modal', function () {
        var ytSRC = $('#youtube').attr('src') + '&autoplay=1';
        $('#youtube').attr('src', ytSRC);
    });

    //Cascading Dropdown
    var options = $(this).children("option:selected").val();
    $('.building-option').hide();
    $(".building-option" + options).show();
    $('#building-field').find("option:not(:hidden):eq(0)");

    $('#location-field').on('change', function () {
        var options = $(this).children("option:selected").val();
        $('.building-option').hide();
        $(".building-option." + options).show();
        $(".building-option." + options).attr('selected', 'true');
    }).trigger('change');

    $('#kmc-people-form');
});

