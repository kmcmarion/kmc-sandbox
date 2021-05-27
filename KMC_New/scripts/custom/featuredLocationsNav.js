$(document).ready(function () {
    $('.location-filter').click(function () {
        $('.all').show();
        var locationClass = $(this).attr('data-value');
        $('.all').hide();
        $('.' + locationClass).slice(0, 6).show();
    });

    $(function () {
        $(".location-item").slice(0, 6).show(); // select the first ten
        $("#load").click(function (e) { // click event for load more
            e.preventDefault();
            $(".location-item:hidden").slice(0, 6).fadeIn(2000); // select next 10 hidden divs and show them
            if ($(".location-item:hidden").length === 0) { // check if any hidden divs still exist              
            }
        });

    });
});