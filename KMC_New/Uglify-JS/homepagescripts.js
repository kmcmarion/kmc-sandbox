"use strict";$(document).ready(function(){$("#searchLocationForm").on("submit",function(t){t.preventDefault();document.getElementById("building-field");var o=$("#building-field").children("option:selected").val();window.location.href=o}),$("#mobile-kv_search").on("submit",function(t){t.preventDefault();var o=document.getElementById("mobile-location-field"),e=o.options[o.selectedIndex].value;window.location.href=e}),$("#video-target").on("hidden.bs.modal",function(){$("#youtube").attr("src",""),$("#youtube").attr("src",$("#closemodal1").attr("data-video-src"))}),$("#video-target").on("show.bs.modal",function(){var t=$("#youtube").attr("src")+"&autoplay=1";$("#youtube").attr("src",t)});var t=$(this).children("option:selected").val();$(".building-option").hide(),$(".building-option".concat(t)).show(),$("#building-field").find("option:not(:hidden):eq(0)"),$("#location-field").on("change",function(){var t=$(this).children("option:selected").val();$(".building-option").hide(),$(".building-option.".concat(t)).show(),$(".building-option.".concat(t)).attr("selected","true")}).trigger("change")});