$(document).ready(function(){var i=$("#building_sync1"),s=$("#building_sync2");i.owlCarousel({items:1,slideSpeed:2e3,nav:!0,autoplay:!0,dots:!1,loop:!0,responsiveRefreshRate:200}).on("changed.owl.carousel",function(e){var o=e.item.count-1,i=Math.round(e.item.index-e.item.count/2-.5);i<0&&(i=o);o<i&&(i=0);s.find(".owl-item").removeClass("current").eq(i).addClass("current");var n=s.find(".owl-item.active").length-1,t=s.find(".owl-item.active").first().index(),l=s.find(".owl-item.active").last().index();l<i&&s.data("owl.carousel").to(i,100,!0);i<t&&s.data("owl.carousel").to(i-n,100,!0)}),s.on("initialized.owl.carousel",function(){s.find(".owl-item").eq(0).addClass("current")}).owlCarousel({items:4,margin:10,dots:!1,nav:!0,smartSpeed:200,slideSpeed:500,slideBy:4,responsiveRefreshRate:100,navText:['<svg width="100%" height="100%" viewBox="0 0 11 20"><path style="fill:none;stroke-width: 1px;stroke: #000;" d="M9.554,1.001l-8.607,8.607l8.607,8.606"/></svg>','<svg width="100%" height="100%" viewBox="0 0 11 20" version="1.1"><path style="fill:none;stroke-width: 1px;stroke: #000;" d="M1.054,18.214l8.606,-8.606l-8.606,-8.607"/></svg>']}).on("changed.owl.carousel",function(e){{var o=e.item.index;i.data("owl.carousel").to(o,100,!0)}}),s.on("click",".owl-item",function(e){e.preventDefault();var o=$(this).index();i.data("owl.carousel").to(o,300,!0)}),$("#buildings_mobile").owlCarousel({loop:!0,nav:!1,dots:!1,margin:10,responsive:{0:{items:1,stagePadding:50},600:{items:1,stagePadding:50}}}),$("#amenities_Carousel").owlCarousel({loop:!1,nav:!0,dots:!1,margin:10,responsive:{1e3:{items:1}}}),$("#amenities_Carousel_mobile").owlCarousel({loop:!0,nav:!1,dots:!1,margin:10,responsive:{0:{items:1},600:{items:1,stagePadding:50}}}),$("#neighborhood_Carousel").owlCarousel({loop:!1,nav:!0,dots:!1,responsive:{600:{items:1},1e3:{items:1}}}),$("#neighborhood_Carousel_mobile").owlCarousel({loop:!0,nav:!1,dots:!1,margin:10,responsive:{0:{items:1},600:{items:1,stagePadding:50}}}),$("a[href*=#]").bind("click",function(e){var o=$(this);$("html, body").stop().animate({scrollTop:$(o.attr("href")).offset().top},1e3),e.preventDefault()}),$(".i-accordion").on("show.bs.collapse",function(e){$(e.target).siblings(".panel-heading").find(".panel-title i").toggleClass("glyphicon glyphicon-angle-up")}),$(".i-accordion").on("hide.bs.collapse",function(e){$(e.target).siblings(".panel-heading").find(".panel-title i").toggleClass("glyphicon glyphicon-angle-down")}),$(document).on("click","#nav-link-locations",function(){var e=$(this).attr("value");return console.log(e),e})}),$(window).resize(function(){990<$(window).width()&&$("#modal-fullscreen").modal("hide")});