//ES6
$(document).ready(function () {
    //KV Search Form on Desktop
    $("#searchLocationForm").on('submit', function (e) {
        e.preventDefault();
        var x = document.getElementById("building-field");
        var selectedBuilding = $('#building-field').children("option:selected").val();
        window.location.href = selectedBuilding;
    });

    //KV Search Form on Mobile
    $("#mobile-kv_search").on('submit', function (e) {
        e.preventDefault();
        var x = document.getElementById("mobile-location-field");
        var selectedLocationMobile = x.options[x.selectedIndex].value;
        window.location.href = selectedLocationMobile;
    });

    //Modal Stop Video
    $('#video-target').on('hidden.bs.modal', function () {
        $('#youtube').attr('src', '');
        $('#youtube').attr('src', $('#closemodal1').attr('data-video-src'));
    });

    //Modal Auto Play
    $('#video-target').on('show.bs.modal', function () {
        var ytSRC = $('#youtube').attr('src') + '&autoplay=1';
        $('#youtube').attr('src', ytSRC);
    });

    //Cascading Dropdown 
    let options = $(this).children("option:selected").val();
    $('.building-option').hide();
    $(`.building-option${options}`).show();
    $('#building-field').find("option:not(:hidden):eq(0)");

    $('#location-field').on('change', function () {
        let options = $(this).children("option:selected").val();
        $('.building-option').hide();
        $(`.building-option.${options}`).show();
        $(`.building-option.${options}`).attr('selected', 'true');
    }).trigger('change');
});