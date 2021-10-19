$(document).ready(function () {
  // Gets the video src from the data-src on each button
  var $videoSrc;
    $("button[data-toggle=modal]").click(function () {
    $videoSrc = "https://www.youtube.com/embed/ujOF6OQfoE4";
    console.log("button clicked" + $videoSrc);
  });

  // when the modal is opened autoplay it
  $("#modal1").on("shown.bs.modal", function(e) {
    console.log("modal opened" + $videoSrc);
    // set the video src to autoplay and not to show related video. Youtube related video is like a box of chocolates... you never know what you're gonna get
    $("iframe").attr(
      "src",
      $videoSrc + "?autoplay=1&showinfo=0&modestbranding=1&rel=0&mute=0"
    );
  });

  // stop playing the youtube video when I close the modal
  $("#modal1").on("hide.bs.modal", function(e) {
    // a poor man's stop video
    $("iframe").attr("src", $videoSrc);
  });
});