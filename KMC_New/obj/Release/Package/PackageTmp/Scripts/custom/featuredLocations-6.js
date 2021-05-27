$(document).ready(function () {
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
        $("#load").click(function (e) { // click event for load more
            e.preventDefault();
            $(".location-item-6:hidden").slice(0, 6).fadeIn(2000); // select next 10 hidden divs and show them
            if ($(".location-item-6:hidden").length === 0) { // check if any hidden divs still exist              
            }
        });
    });
});