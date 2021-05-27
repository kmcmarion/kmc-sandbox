// Set the date we're counting down to
var countDownDate = new Date("May 20, 2021 11:00:00").getTime();

// Update the count down every 1 second
var x = setInterval(function () {

    // Get today's date and time
    var now = new Date().getTime();

    // Find the distance between now and the count down date
    var distance = countDownDate - now;

    // Time calculations for days, hours, minutes and seconds
    var days = Math.floor(distance / (1000 * 60 * 60 * 24));
    var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));

    document.getElementById("dayNumber").innerHTML = days;
    document.getElementById("hourNumber").innerHTML = hours;
    document.getElementById("minNumber").innerHTML = minutes;

    // If the count down is finished, write some text
    if (distance < 0) {
        clearInterval(x);
        document.getElementById("dayNumber").innerHTML = "0";
        document.getElementById("hourNumber").innerHTML = "0";
        document.getElementById("minNumber").innerHTML = "0";
    }
}, 1000);