$(document).ready(function(){$(".location-filter").click(function(){$(".all").show();var i=$(this).attr("data-value");$(".all").hide(),$("."+i).slice(0,6).show()}),$(function(){$(".location-item").slice(0,6).show(),$("#load").click(function(i){i.preventDefault(),$(".location-item:hidden").slice(0,6).fadeIn(2e3),$(".location-item:hidden").length})})});