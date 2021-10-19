$(document).ready(function(){    
    var video1 = "https://www.youtube.com/embed/ujOF6OQfoE4";
    var video2 = "https://www.youtube.com/embed/ThmzE9CEHz8";
    var video3 = "https://www.youtube.com/embed/XkWPwTjTMn8";
    var video4 = "https://www.youtube.com/embed/XkWPwTjTMn8";

    $(".video-1 img").click(function(){
        $(".video-player iframe").attr("src", video1 + "?autoplay=1&rel=0");
    });

    $(".video-2 img").click(function(){
        $(".video-player iframe").attr("src", video2 + "?autoplay=1&rel=0");
    });

    $(".video-3 img").click(function(){
        $(".video-player iframe").attr("src", video3 + "?autoplay=1&rel=0");
    });

    $(".video-4 img").click(function(){
        $(".video-player iframe").attr("src", video4 + "?autoplay=1&rel=0");
    });

})