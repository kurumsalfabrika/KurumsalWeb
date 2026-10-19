// datetime özniteliğinden tarih al
const timeElements = document.querySelectorAll('.my-time');

timeElements.forEach((timeElement) => {
	const datetimeValue = timeElement.getAttribute('datetime');
	const dateObject = new Date(datetimeValue);

	// Günü al ve formatla, ardından time öğesine yazdır
	const dayOfMonth = dateObject.getDate();
	const formattedDay = dayOfMonth < 10 ? '0' + dayOfMonth : dayOfMonth;
	timeElement.textContent = formattedDay;
});
/*fixed menu*/
$('.menu-toggle').click(function () {
	$('#filter').toggleClass('show');
});
$(window).scroll(function () {
	var navHeight = 100;
	if ($(window).scrollTop() > navHeight) {
		$('.header').addClass('fixed');
		$('body').addClass('fixed');
		$('#toTop').fadeIn();
	}
	else {
		$('#toTop').fadeOut();
		$('.header').removeClass('fixed');
		$('body').removeClass('fixed');
	}
});

$("#fullpage").scroll(function () {
	var navHeight = 100;

	if ($(this).scrollTop() > navHeight) {
		$('.header').addClass('fixed');
		$('#toTop').fadeIn();
	} else {
		$('#toTop').fadeOut();
		$('.header').removeClass('fixed');
	}
});


// Document'a tıklama olayını ekle
$(document).on("click", function (event) {
	// Tıklanan öğe div değilse
	if (!$(".mobilemenu").is(event.target) && $(".mobilemenu").has(event.target).length === 0 && !$(".menuac").is(event.target) && $(".menuac").has(event.target).length === 0) {
		$(".mobilemenu").removeClass("active");
		$(".menuac span").html("menu");
		$("body").removeClass("noscroll");
		$(this).find("a>span").removeClass("active");
	}
});


$(".menuac").click(function () {

	$(".mobilemenu").toggleClass("active");

	if ($(".mobilemenu").hasClass("active")) {
		$(".menuac span").html("close");
		$("body").addClass("noscroll");
		$(this).find("a>span").addClass("active");

	}
	else {
		$(".menuac span").html("menu");
		$("body").removeClass("noscroll");
		$(this).find("a>span").removeClass("active");
	}

});


$(".combobox").click(function () {
	var selectElement = $(this).find(".select");
	$(".combobox .select:visible").not(selectElement).fadeOut(100);


	// Eğer görünürse, kapat
	if (selectElement.is(":visible")) {
		selectElement.fadeOut("100");
	} else {
		// Görünmüyorsa, aç
		selectElement.fadeIn("500");
	}

});

$(".combobox.color").click(function () {
	var materialid = $(this).closest(".ikili").find(".material .head").data("id");

	// COLOR combobox'ındaki seçenekleri filtrele
	$(this).find(".select div").each(function () {
		var colorMaterialId = $(this).data("catid");
		if (colorMaterialId == materialid) {
			$(this).show();
		} else {
			$(this).hide();
		}
	});
});


$(".combobox.material .select div").click(function () {
	$(this).closest(".ikili").find(".color p").text("COLOR");
});


$(".combobox .select div").click(function () {
	var dataid = $(this).data("id");
	var datacat = $(this).data("cat");
	var datacatid = $(this).data("catid");

	var clickedContent = $(this).text();
	var pElement = $(this).closest(".combobox").find(".head").data("id", dataid);
	var pElement = $(this).closest(".combobox").find("p");
	pElement.text(clickedContent);
	$(this).closest(".ikili").find(".color").fadeIn("500");

});






$(window).load(function () {


	$(".carousel").slick('slickSetOption', 'autoplaySpeed', ImagePauses[0], true);
	$('.carousel').on('afterChange', function (event, slick, currentSlide, nextSlide) {
		//alert("hello");
		//alert('Current slide: ' + currentSlide + '. Setting speed to: ' + ImagePauses[currentSlide]);

		$(".carousel").slick('slickSetOption', 'autoplaySpeed', ImagePauses[currentSlide], true);
	});
	$('.carousel').on('beforeChange', function (event, slick, currentSlide, nextSlide) {
		//alert("hello2");
		// Tümm videoları başa sar
		$('video').each(function () {
			this.currentTime = 0;
		});
		$("#slick-slide00 .carousel__text").css("opacity", 0);

	});

	$(".zoom-gallery .zoom").mouseover(function () {
		// Buraya fare üzerine gelindiğinde yapılması istenen işlemleri ekleyebilirsin.
		$(this).parents(".zoom-gallery").find(".zoom").addClass("pasif");
		$(this).removeClass("pasif");
	});

	$(".zoom-gallery").mouseout(function () {
		// Fare öğenin üzerinden çıkınca yapılması istenen işlemleri ekleyebilirsin.
		$(".zoom-gallery .zoom").removeClass("pasif");
	});

	var maxgoster = 8;
	$(".product .item .list").each(function () {
		var acount = $(this).data("acount");
		var totalHeight = $(this).find(".facetwp-checkbox").outerHeight(false);
		//alert(acount);
		if (acount > maxgoster) {

			$(this).css("height", (totalHeight * maxgoster) + "px");
		}
		else {
			$(this).css("height", (totalHeight * acount) + "px");
		}
	});

	$(".categ").click(function () {
		$(this).toggleClass("active");
		$(this).parents(".item").find(".moreplus").toggleClass("hide");

	});




	$(".prodetail .alttab>.produt-features_tab>li").click(function () {
		$(".prodetail .alttab>.produt-features_tab>li").removeClass("active");
		$(this).toggleClass("active");

	});

	$(".searchbutton").click(function () {
		$(".sourcebox").fadeIn();
		$(".sourcebox").find("input").focus();
	});

	$(document).click(function (event) {
		// Tıklanan elemanın sourcebox içinde olup olmadığını kontrol et
		if (!$(event.target).closest('.header').length) {
			// sourcebox dışına tıklandığında kapat
			$(".sourcebox").fadeOut();
		}

	});


	$(".sepetbox").click(function () {
		var self = $(this);
		self.toggleClass("active");
		var mesaj = self.data("mesaj");
		var anamesaj = self.find(".txt").text();
		self.find(".txt").text(mesaj);
		self.find(".material-symbols-outlined").text("check");
		$(".basket-preview-container").addClass("active");

		// 2000 milisaniye (2 saniye) sonra sınıfı tekrar sil Kaydettikten sonra silinecek
		setTimeout(function () {
			self.removeClass("active");
			self.find(".txt").text(anamesaj);
			self.find(".material-symbols-outlined").text("shopping_cart");
		}, 1000);


	});

	$(".basket-preview-container").mouseout(function () {
		$(this).removeClass("active");
	});

	$(".moreplus").click(function () {
		var acount = $(this).parents(".item").find(".list").data("acount");
		var totalHeight = $(this).parents(".item").find(".facetwp-checkbox").outerHeight(false);

		if ($(this).hasClass("active")) {
			$(this).parents(".item").find(".list").css("height", maxgoster * totalHeight + "px");
		}
		else {
			$(this).parents(".item").find(".list").css("height", acount * totalHeight + "px");
		}

		$(this).toggleClass("active");
	});

	$(".facetwp-checkbox").click(function () {
		$(this).toggleClass("checked");
	});



	$('.zoom-gallery').magnificPopup({
		delegate: 'a',
		type: 'image',
		closeOnContentClick: false,
		closeBtnInside: false,
		mainClass: 'mfp-with-zoom mfp-img-mobile',
		image: {
			verticalFit: true,
			titleSrc: function (item) {
				return item.el.attr('title');
			}
		},
		gallery: {
			enabled: true
		},
		zoom: {
			enabled: true,
			duration: 300, // don't foget to change the duration also in CSS
			opener: function (element) {
				return element.find('img');
			}
		}

	});




	//add source to video tag
	function addSourceToVideo(element, src) {
		var source = document.createElement('source');
		source.src = src;
		source.type = 'video/mp4';
		console.log(src);
		element.appendChild(source);

	}

	//determine screen size and select mobile or desktop vid
	function whichSizeVideo(element, src) {

		var windowWidth = window.innerWidth ? window.innerWidth : $(window).width();
		if (windowWidth > 1200) {
			addSourceToVideo(element, src.dataset.desktopVid);
			setTimeout(function () { addSourceToVideo(element, src.dataset.desktopVid); }, 100);
		}
		else {

			if (src.dataset.ilkvideo == "fist") { addSourceToVideo(element, src.dataset.mobileVid); }
			else {
				setTimeout(function () { addSourceToVideo(element, src.dataset.mobileVid); }, 200);
			}

		}
		element.play();
	}

	//init only if page has videos
	function videoSize() {
		if (video !== undefined) {
			video.forEach(function (element, index) {

				whichSizeVideo(
					element, //element
					element  //src locations
				);
			});
		}
	}



	var video = document.querySelectorAll(".sladervideo");

	videoSize();
	$('video').on('loadstart waiting seeking stalled', function (event) {
		$(this).addClass('loading');
	});
	$('video').on('canplay seeked play', function (event) {
		$(this).removeClass('loading');
	}); s



	$(".opentab>h2").click(function () {
		$(".opentab>div").slideUp();



		var secilenid = $(this).attr('class')
		if (secilenid.indexOf("active") > -1) {
			$(this).removeClass("active");
			$("#" + secilenid).slideDown();
		}
		else {
			$(".opentab>h2").removeClass("active");
			$(this).addClass("active");
			secilenid = secilenid.replace(" active", "");

			$("#" + secilenid).slideToggle();
		}

	});

	$(".menu .logo .line").css("left", $(".menu .logo img").width());
	$(".news .zoomimg .img").height($(".news .zoomimg .img img").height());
	$(".homeslo>div").height($(".txtkalite").height() + 150);


	/*speed time*/

	var mhp = 250;
	var bhp = 1140;
	var saat = 5;

	var gmhp = $(".speedtime .model-stat:nth-child(1) .model-stat__value").text();
	var gbhp = $(".speedtime .model-stat:nth-child(2) .model-stat__value").text();
	var gsaat = $(".speedtime .model-stat:nth-child(3) .model-stat__value").text();

	if (gmhp > mhp) { gmhp = mhp; }
	if (gbhp > bhp) { gbhp = bhp; }
	if (gsaat > saat) { gsaat = saat; }


	$(".speedtime .model-stat:nth-child(1) .model-stat__line--val").css("width", ((gmhp * 100) / mhp) + "%");
	$(".speedtime .model-stat:nth-child(2) .model-stat__line--val").css("width", ((gbhp * 100) / bhp) + "%");
	$(".speedtime .model-stat:nth-child(3) .model-stat__line--val").css("width", ((gsaat * 100) / saat) + "%");

	/*Speed time end*/

	setTimeout(function () {
		$(".menu .logo .line").css("transition", ".5s");
		$(".menu .logo .line").width($(".menu>div").width() - $(".menu .logo img").width());
	}, 100);

	AOS.refresh();
});

/*Modal a? -kapa*/
function modalac(divid, pozisyon, tab, id) {

	if (pozisyon != "center" && pozisyon != "") {
		$(".dialog-center").css("width", pozisyon);
		$(".dialog-center").css("max-width", pozisyon);
	}

	if (tab == 0) { tab = 1; }
	if ($(id).data("name")) {
		veri = "[ " + $(id).data("name") + " ]";
		$(".sepet-sil-modal-icerik>div p>span").html(veri);
	}

	divid = "#" + divid;
	divgoster = divid + ">div>div>div";
	altdivgoster = ".modal-icerik>div:nth-child(" + tab + ")"; //gelen i??eri??i se??
	$(".modal-icerik>div").css("display", 'none'); //t??m??n?? gizle
	$(altdivgoster).css("display", 'block');       // se??ileni g??ster  
	tab = ".modal-buton:nth-child(" + tab + ")";
	$(divid).fadeIn("slow");
	$(divgoster).slideDown("slow");
	$(".modal-buton").removeClass("active");
	$(tab).addClass("active");
}

function modalkapat(divid, pozisyon) {
	event.preventDefault();
	divid = "#" + divid;
	divgoster = divid + ">div>div>div";

	$(divid).fadeOut("slow");
	$(divgoster).slideUp("slow");
}
/*Modal a?? -kapa bitti*/



$(document).ready(function () {


	const container = document.querySelector('.slader .carousel__slide');
	/*	const img = document.querySelector('.bgarma img');*/
	const img1 = document.querySelector('.engener img');

	container.addEventListener('mousemove', (e) => {
		const { clientX, clientY } = e;
		const { left, top, width, height } = container.getBoundingClientRect();

		const xPercent = (clientX - left) / width * 3;
		const yPercent = (clientY - top) / height * 3;

		/*img.style.transform = `translate(-${xPercent}%, -${yPercent}%)`; */
		img1.style.transform = `translate(-${xPercent}%, -${yPercent}%)`;
	});

	container.addEventListener('mouseleave', () => {
		img1.style.transform = 'translate(0%, 0%)';
	});





	// Tüm .mutedvideos sınıfına sahip videoları seç
	var mutedVideos = document.querySelectorAll('.mutedvideos');

	// Her bir videoyu döngü ile işle
	mutedVideos.forEach(function (video) {
		// Videoyu oynat
		video.play();
	});


	$(".sepetekle").click(function () {

		$(".shoping-box").attr("style", "display:flex");
	});

	$(".sepet").click(function () {
		$(".shoping-box").attr("style", "display:flex");
	});

	$(".devam").click(function () {
		$(".shoping-box").attr("style", "display:none");
	});

	$(".date").datepicker(
		{
			dateFormat: "dd-mm-yy",
			altFormat: "yy-mm-dd",
			altField: "#tarih-db",
			monthNames: ["Ocak", "??ubat", "Mart", "Nisan", "May??s", "Haziran", "Temmuz", "A??ustos", "Eyl??l", "Ekim", "Kas??m", "Aral??k"],
			dayNamesMin: ["Pa", "Pt", "Sl", "??a", "Pe", "Cu", "Ct"],
			firstDay: 1
		}
	);

	$('.laftImg').BUP(null, 1, 5);
	$('.mapsImg').BUP(null, 1, 5);

	//Yuotube //
	$('.popup-youtube, .popup-vimeo, .popup-gmaps').magnificPopup({
		//disableOn: 700,
		type: 'iframe',
		mainClass: 'mfp-fade',
		removalDelay: 160,
		preloader: false,
		fixedContentPos: false,
		iframe: {
			markup: '<div class="mfp-iframe-scaler">' +
				'<div class="mfp-close"></div>' +
				'<iframe class="mfp-iframe" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>' +
				'</div>',
			patterns: {
				youtube: {
					index: 'youtube.com/',
					id: 'v=',
					src: 'https://www.youtube.com/embed/%id%?autoplay=1'
				}
			}
		}

	});


	$('.popup-youtube, .popup-text').magnificPopup({
		disableOn: 320,
		type: 'iframe',
		mainClass: 'mfp-fade',
		removalDelay: 160,
		preloader: false,
		fixedContentPos: true
	});

	$('.appbuilder-slick').slick({
		dots: true,
		arrows: false,
		infinite: true,
		speed: 500,
		fade: true,
		cssEase: 'linear'
	});


	var ImagePauses = [6000, 6000, 6000, 6000, 6000, 6000, 6000, 6000];
	i = 0;


	$('.homeslader .carousel__slide').each(function () {
		newtime = $(this).data("time");
		ImagePauses[i] = newtime;

		i = i + 1;
	});

	$('.carousel').slick({
		slidesToShow: 1,
		slidesToScroll: 1,
		arrows: true,
		fade: false,
		dots: true,
		infinite: true,
		mobileFirst: true,
		pauseOnHover: false,
		pauseOnFocus: false,
		centerMode: false,
		variableWidth: false,
		centerPadding: '0%',
		rows: 0,
		zIndex: 75,
		draggable: true,
		autoplay: false, /* this is the new line */
		autoplaySpeed: ImagePauses[0],
		touchThreshold: 1000,
		responsive: [
			{
				breakpoint: 580,
				settings: {
					slidesToShow: 1,
					slidesToScroll: 1
				}
			}
		]
	});


	$('.carousel-1').slick({
		slidesToShow: 1,
		slidesToScroll: 1,
		arrows: true,
		fade: false,
		dots: true,
		infinite: true,
		mobileFirst: true,
		pauseOnHover: false,
		pauseOnFocus: false,
		centerMode: false,
		variableWidth: false,
		centerPadding: '0%',
		rows: 0,
		zIndex: 75,
		draggable: true,
		autoplay: false, /* this is the new line */
		autoplaySpeed: ImagePauses[0],
		touchThreshold: 1000,
		responsive: [
			{
				breakpoint: 580,
				settings: {
					slidesToShow: 1,
					slidesToScroll: 1
				}
			}
		]
	});
	$('.treegallery').slick({
		dots: true,
		arrows: true,
		infinite: true,
		slidesToShow: 3,
		slidesToScroll: 3,
		responsive: [




			{
				breakpoint: 1080,
				settings: {
					slidesToShow: 2,
					slidesToScroll: 1, 
				}
			},
			{
				breakpoint: 650,
				settings: {
					slidesToShow: 1,
					slidesToScroll: 1, 
				}
			}
		]
	});


	$('.karsilastirma').slick({
		dots: false,
		arrows: true,
		infinite: true,
		slidesToShow: 4,
		slidesToScroll: 4,
		rows: 4,
		variableWidth: false,
		responsive: [
			{
				breakpoint: 650,
				settings: {
					slidesToShow: 1,
					slidesToScroll: 1, i
				}
			}
		]
	});

	$("#slick-slide00 .carousel__text").css("opacity", 1);



	// Ana banner find elements
	var carousel = $(".carousel");

	var options = {
		adaptiveHeight: true,
		arrows: true,
		dots: true,
		fade: true,
		autoplay: true,
		infinite: true,
		mobileFirst: true,
		rows: 0,
		slidesToScroll: 1,
		slidesToShow: 1,
		centerMode: false,
		variableWidth: false,
		centerPadding: '0%',
		speed: 0,
		zIndex: 75
	};

	var addAnimationClass = true;

	carousel.on('beforeChange', function (e, slick, current, next) {
		var current = carousel.find('.slick-slide')[current];
		var next = carousel.find('.slick-slide')[next];
		var src = $(current).find('.carousel__image').attr('src');

		$(next).find('.carousel__slide__overlay').css('background-image', 'url("' + src + '")');


		if (addAnimationClass) {
			carousel.addClass('doAnimation');

			// so that adding the class only happens once
			addAnimationClass = false;
		}
	});

	carousel.not('.slick-initialized').slick(options);
	//Ana banner bitti



	$('.slider-for').slick({
		slidesToShow: 1,
		slidesToScroll: 1,
		arrows: true,
		fade: true,
		asNavFor: '.slider-nav'
	});
	$('.slider-nav').slick({
		slidesToShow: 5,
		slidesToScroll: 1,
		asNavFor: '.slider-for',
		dots: false,
		centerMode: true,
		focusOnSelect: true
	});



	// Main Page Slider
	if ($.fn.slick) {
		$('.main-slider').slick({
			dots: false,
			arrows: false,
			infinite: true,
			speed: 500,
			fade: true,
			autoplay: true,
			autoplaySpeed: 4000,
			cssEase: 'linear'
		});

		$('.testimonials-area__slider').slick({
			dots: false,
			arrows: false,
			infinite: true,
			slidesToShow: 2,
			slidesToScroll: 1,
			centerMode: false,
			responsive: [
				{
					breakpoint: 580,
					settings: {
						centerMode: true,
						variableWidth: true,
						slidesToShow: 1,
						slidesToScroll: 1
					}
				}
			]
		});

		$(".slider-prev").click(function (e) {
			e.preventDefault();
			$('.testimonials-area__slider, .customers-area__slider').slick("slickPrev");
		});

		$(".slider-next").click(function (e) {
			e.preventDefault();
			$('.testimonials-area__slider, .customers-area__slider').slick("slickNext");
		});


		// Left Product Photo Slider//

		$('.textleftslider').slick({
			dots: false,
			arrows: true,
			infinite: true,
			slidesToShow: 2,
			slidesToScroll: 2,
			centerMode: false,
			variableWidth: false,
			responsive: [
				{
					breakpoint: 650,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1
					}
				}
			]

		});

		$('.leftsliderteam').slick({
			dots: false,
			arrows: true,
			infinite: true,
			slidesToShow: 2,
			slidesToScroll: 1,
			variableWidth: false,
			centerMode: true,
			centerPadding: '0%',
			responsive: [
				{
					breakpoint: 650,
					settings: {
						slidesToShow: 1
					}
				}
			]
		});

		$('.leftslider').slick({
			dots: false,
			arrows: true,
			infinite: true,
			slidesToShow: 1,
			slidesToScroll: 1,
			variableWidth: false,
			centerMode: true,
			centerPadding: '15%',
			responsive: [
				{
					breakpoint: 650,
					settings: {
						centerMode: false
					}
				}
			]
		});






		$('.karsilastirma').slick({

			dots: false,
			arrows: true,
			infinite: true,
			slidesToShow: 3,
			slidesToScroll: 1,
			variableWidth: false,
			centerMode: true,
			centerPadding: '10%',
			responsive: [
				{
					breakpoint: 650,
					settings: {
						arrows: true,
						dots: true,
						slidesToShow: 1,
						slidesToScroll: 1
					}
				}
			]
		});

		// Product Photo Slider//

		$('.newsgallery').slick({
			lazyLoad: 'ondemand',
			dots: false,
			arrows: true,
			infinite: true,
			slidesToShow: 3,
			slidesToScroll: 1,
			centerMode: false,
			variableWidth: false,
			responsive: [
				{
					breakpoint: 1080,
					settings: {
						slidesToShow: 2
					}
				},
				{
					breakpoint: 650,
					settings: {
						slidesToShow: 1
					}
				}
			]
		});



		$(".product-intro-wrapper__slider").slick({
			lazyLoad: 'ondemand',
			dots: true,
			arrows: false,
			slidesToShow: 1,
			slidesToScroll: 1
		});

	}

	//B?y?k Galeri 
	$('.slider').slick({
		slidesToShow: 1,
		slidesToScroll: 1,
		arrows: false,
		fade: false,
		dots: false,
		asNavFor: '.slider-nav-thumbnails'
	});

	$('.slider-nav-thumbnails').slick({
		slidesToShow: 4,
		slidesToScroll: 4,
		asNavFor: '.slider',
		dots: false,
		arrows: false,
		focusOnSelect: true
	});

	// Remove active class from all thumbnail slides
	$('.slider-nav-thumbnails .slick-slide').removeClass('resim-active');

	// Set active class to first thumbnail slides
	$('.slider-nav-thumbnails .slick-slide').eq(0).addClass('resim-active');

	// On before slide change match active thumbnail to current slide
	$('.slider').on('beforeChange', function (event, slick, currentSlide, nextSlide) {
		var mySlideNumber = nextSlide;
		$('.slider-nav-thumbnails .slick-slide').removeClass('resim-active');
		$('.slider-nav-thumbnails .slick-slide').eq(mySlideNumber).addClass('resim-active');
	});
	//B?y?k Galeri bitti



	//video popup
	$(".icon-play").click(function () {

		var mVideos = $(this).parents(".videopopup").find(".vdetail");
		var mediaVideo = $(mVideos).find("video");

		$(mVideos).fadeToggle(200);
		if ($(mVideos).find("video").attr('src') == "" || $(mVideos).find("video").attr('src') == null) {
			$(mVideos).find("video").attr('src', $(this).data("video"));
		}
		$(mediaVideo).trigger('play');
		$(mVideos).find(".pause").addClass("active");
		$(mVideos).find(".play").removeClass("active");

	});


	$(".videopopup .close").click(function () {

		var mVideos = $(this).parents(".vdetail");
		var mediaVideo = $(mVideos).find("video");

		$(mediaVideo).trigger('pause');
		$(mVideos).fadeToggle(200);

		$(mVideos).find(".pause").addClass("active");
		$(mVideos).find(".play").removeClass("active");

	});


	$(".videopopup .vdetail .pauseplay").click(function () {

		var mVideos = $(this).parents(".videopopup").find(".vdetail");
		var mediaVideo = $(this).parents(".vdetail").find("video");

		if ($(mVideos).find(".pause").hasClass("active") == false) {
			$(mediaVideo).trigger('play');
			$(mVideos).find(".pause").addClass("active");
			$(mVideos).find(".play").removeClass("active");
		}
		else {
			$(mediaVideo).trigger('pause');
			$(mVideos).find(".pause").removeClass("active");
			$(mVideos).find(".play").addClass("active");
		}



	});



	$(".videopopup .vdetail video").click(function () {

		var mediaVideos = $(".videopopup .vdetail video");
		var mVideos = $(this).parents(".videopopup").find(".vdetail");

		mediaVideos.each(function () {
			var mediaVideo = this;

			if (mediaVideo.paused) {
				mediaVideo.play();
				$(mVideos).find(".pause").addClass("active");
				$(mVideos).find(".play").removeClass("active");
			} else {
				mediaVideo.pause();
				$(mVideos).find(".pause").removeClass("active");
				$(mVideos).find(".play").addClass("active");
			}
		});



	});
	//video popup end

	$(function () {
		$('a[href*=#]').on('click', function (e) {
			e.preventDefault();
			$('html, body').animate({ scrollTop: $($(this).attr('href')).offset().top }, 500, 'linear');
		});
	});

	// Gallery
	$('.imgpopup').magnificPopup({
		delegate: 'a',
		type: 'image',
		closeOnContentClick: true,
		closeBtnInside: false,
		fixedContentPos: true,
		mainClass: 'mfp-no-margins mfp-with-zoom',
		gallery: {
			enabled: true,
			navigateByImgClick: true,
			preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
		},
		image: {
			verticalFit: true
		},
		zoom: {
			enabled: true,
			duration: 300 // don't foget to change the duration also in CSS
		}
	});

	// Gallery
	$('.product-photos__slider').magnificPopup({
		delegate: 'a',
		type: 'image',
		closeOnContentClick: true,
		closeBtnInside: false,
		fixedContentPos: true,
		mainClass: 'mfp-no-margins mfp-with-zoom',
		gallery: {
			enabled: true,
			navigateByImgClick: true,
			preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
		},
		image: {
			verticalFit: true
		},
		zoom: {
			enabled: true,
			duration: 300 // don't foget to change the duration also in CSS
		}
	});

	// Zoom on certificates documents
	$('.certificate-lightbox').magnificPopup({
		type: 'image',
		closeOnContentClick: true,
		closeBtnInside: false,
		fixedContentPos: true,
		mainClass: 'mfp-no-margins mfp-with-zoom',
		gallery: {
			enabled: true,
			navigateByImgClick: true,
			preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
		},
		image: {
			verticalFit: true
		}
	});

	// Shopping Cart
	$(".tools-nav__item--basket").click(function (e) {
		e.preventDefault();
		e.stopPropagation();
		$(".shopping-cart").addClass("shopping-cart--open");
		$("html, body").addClass("no-scroll");
	});

	$(".shopping-cart__close").click(function (e) {
		e.preventDefault();
		$(this).parent().removeClass("shopping-cart--open");
		$("html, body").removeClass("no-scroll");
	});

	$("body").click(function () {
		$(".shopping-cart").removeClass("shopping-cart--open");
		$("html, body").removeClass("no-scroll");
	});

	$(".shopping-cart").click(function (e) {
		e.stopPropagation();
	});

	// Mattress tooltips
	$(".mattress-area .tooltip a, .cellpur-layer-area__mattress .tooltip a").click(function (e) {
		e.preventDefault();
		var hasClass = $(this).parent().hasClass("tooltip--open");
		$(".mattress-area .tooltip, .cellpur-layer-area__mattress .tooltip").removeClass("tooltip--open");
		if (hasClass) {
			$(this).parent().removeClass("tooltip--open")
		} else {
			$(this).parent().addClass("tooltip--open");
		}
	});

	// Form Validatte
	if ($.fn.parsley) {
		$('.form-block-wrapper form, .section form').parsley();
	}

	// Custom File Input
	$(".file-upload input").on('change', function () {
		var value = $(this)[0].files[0].name;
		$(this).parent().find("label").text(value);
	});


	if ($.fn.hideseek) {
		$('.search-box input').hideseek();
	}

	// Sizing Guide
	$(".page-sizing_guide__type li").hover(function () {
		$(".page-sizing_guide__type li").removeClass("active");
		$(this).addClass("active");
		var currentId = $($(this).data("selector"));
		$(".page-sizing_guide__text").removeClass("active");
		currentId.addClass("active");
	});


	// Accordion
	(function ($) {
		$.fn.accordion = function (item, content, openOneItem) {
			if (item == "destroy" && $(this).data('accordion')) {
				$(this).find(this.data("item")).unbind("click");
				$(this).find(this.data("content")).unbind("click").removeAttr('style');
				$(this).removeData('accordion');
			} else if (!$(this).data('accordion')) {
				// General Accordion
				var that = this;
				this.data("item", item);
				this.data("content", content);

				var openOneItem = openOneItem || false;
				$(this).find(item).each(function () {
					$(this).data('top-pos', $(this).offset().top);
				});

				$(this).find(item).click(function (e) {
					if (openOneItem) {
						that.find(item).removeClass(item.substr(1) + '--active');
						that.find(content).slideUp();
					}
					else if ($(this).find(content).is(':hidden') == true) {
						$(this).addClass(item.substr(1) + '--active');
						if (($(window).width() < 769) && ($("body").hasClass("index"))) {
							$("html, body").animate({ scrollTop: $(this).data('top-pos') }, 400);
						}
						$(this).find(content).slideDown();

						$(this).parent().parent().find(item).not($(this)).removeClass(item.substr(1) + '--active');
						$(this).parent().parent().find(item).not($(this)).find(content).slideUp();
					}
					else {
						$(this).removeClass(item.substr(1) + '--active');
						$(this).find(content).slideUp();
					}
					e.preventDefault();
				});
				$(this).find(item + '--active ' + content).show();

				$(this).find(content).click(function (e) {
					e.stopPropagation();
				});
				$(this).data('accordion', true)
			}
		}
	})($);
	$('.accordion').accordion('.accordion__item', '.accordion__item-content');


	// -------------------------- Product Detail Page --------------------------

	// Custom select box
	(function customSelect() {
		$(".custom-select-box__label").click(function (e) {
			e.preventDefault();
			$(".custom-select-box__wrap").toggleClass("open");
		});

		$(".custom-select-box__list li").click(function (e) {
			e.preventDefault();
			$(".custom-select-box__label").text($(this).clone().children().remove().end().text());
			$(this).parents('form').find("[name='id']").val($(this).data("id"));
			// changeVariant($(this).data("id"));
			$(".custom-select-box__wrap").removeClass("open");
		});

		$(document).on('click', function (e) {
			if (!$(e.target).closest(".custom-select-box__label").length) {
				$(".custom-select-box__wrap").removeClass("open");
			}
		});

	})();

	$(".product-intro-wrapper__desc .selectbox select").change(function () {
		$(".product-intro-wrapper__desc .selectbox select option:selected").each(function () {
			$(".product-intro-wrapper__desc .price__discounted-value").text($(this).attr("data-price"));
			if ($(".price__original")) {
				$(".product-intro-wrapper__desc .price__original").text($(this).attr("data-price-original"));
			}
			var currentDiscountPrice = $(this).attr("data-price").split('TL');
			var currentPrice = parseInt(currentDiscountPrice[0].replace(/\,/g, ''), 0);
			var discount_15 = Math.ceil((currentPrice / 100) * 25);
			var discount_25 = Math.ceil((currentPrice / 100) * 10);

			$('.discount_15').text(Intl.NumberFormat('en-US').format(currentPrice - discount_15) + 'TL');
			$('.discount_25').text(Intl.NumberFormat('en-US').format(currentPrice - discount_25) + 'TL');
		});
	});

	$('[name="product-color"]').change(function (e) {
		var value = $(this).val();
		$('[name="id"]').find('option').remove();
		$("option[data-color='" + value + "']").clone().appendTo('[name="id"]');
		$('[name="id"]').change(function (e) {
			var price = $("option[value='" + $(this).val() + "']").data('price');
			$('.product-intro-wrapper__desc form .price .price__original').text(price);
		});
		$('[name="id"]').change();
	});
	$('[name="product-color"]:checked').change();
	// -------------------------------------------------------------------------

	// Career Form
	(function careerForm() {
		$('[name="openPosition"]').change(function (e) {
			$('[name="position"]').val($(this).val());

			$('html, body').animate({
				scrollTop: $("#ApplicationForm").offset().top
			}, 1000);
		});

		$('#career-form').submit(function (e) {
			if (!$('[name="position"]').val()) {
				e.preventDefault();
				alert("Please Select A Position");
			}
		});
	})();


	(function formInputFocus() {
		$('.form-block-wrapper input').focus(function () {
			$(this).parent().addClass('focused');
		});
		$('.form-block-wrapper input').blur(function () {
			var inputValue = $(this).val();
			if (inputValue == "") {
				$(this).parent().removeClass('focused');
			}
		});
		$('.form-block-wrapper input').each(function (i, item) {
			if ($(item).val()) {
				$(item).parent().addClass('focused');
			}
		});
	})();

	$(".selectbox select").change(function (e) {
		$(this).parent().parent().find("label").not(':has(".custom-radio"').hide();
		$("#province-wrapper-new").find("label").not(':has(".custom-radio"').hide();
	});


	// Product Header
	var revealPoint = $(".product-cover").height();
	$(window).on('scroll', function () {
		/**Fixed header**/
		if ($(window).scrollTop() > revealPoint) {
			$('.product-header').css("top", $('header').height());
		} else {
			$('.product-header').css("top", "-155px");
		}
	});


	// Gallery Button
	$(".product-cover__text a").click(function (e) {
		e.preventDefault();
		$('html, body').animate({
			scrollTop: $(".product-photos__slider").offset().top - 280
		}, 1000);
	});

	$(".product-intro-wrapper__slider-item-text a").click(function (e) {
		e.preventDefault();
		$('html, body').animate({
			scrollTop: $(".product-photos__slider").offset().top - 170
		}, 1000);
	});


	// Zoom on certificates documents
	$('.certificate-lightbox').magnificPopup({
		type: 'image',
		closeOnContentClick: true,
		closeBtnInside: false,
		fixedContentPos: true,
		mainClass: 'mfp-no-margins mfp-with-zoom',
		gallery: {
			enabled: true,
			navigateByImgClick: true,
			preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
		},
		image: {
			verticalFit: true
		}
	});


	// More Text
	$(".info a").click(function (e) {
		e.preventDefault();
		$(".info p").toggleClass("more-text");
	});


	// Mobile Responsive Js
	enquire.register("screen and (max-width:768px)", {
		match: function () {
			$(".diffrence-area__item-wrap").slick({
				dots: false,
				arrows: false,
				slidesToShow: 3,
				slidesToScroll: 1,
				adaptiveHeight: true,
				responsive: [
					{
						breakpoint: 767,
						settings: {
							dots: true,
							slidesToShow: 1
						}
					}
				]
			});

			$(".tools-nav__item--basket").click(function (e) {
				$(".shopping-cart").removeClass("shopping-cart--open");
				$(".mobile-menu, .tools-nav__item--mobile").removeClass("active");
				$(this).toggleClass("active");
				var headerHeight = $('header').height();
				if ($(this).hasClass("active")) {
					$(".shopping-cart").css({ 'top': headerHeight, 'height': "calc(100vh - " + headerHeight + "px)" });
					$(".shopping-cart").addClass("shopping-cart--open");
				} else {
					$(".shopping-cart").removeClass("shopping-cart--open");
					$(".shopping-cart").removeAttr("style");
					$("html, body").removeClass("no-scroll");
				}
			});

			$(".tools-nav__item--mobile").click(function (e) {
				e.preventDefault();
				$(this).toggleClass("active");
				$(".mobile-menu").toggleClass("active");
				$(".tools-nav__item--basket").removeClass("active");
				$(".shopping-cart").removeClass("shopping-cart--open");
				var headerHeight = $('header').height();
				if ($(".mobile-menu").hasClass("active")) {
					$(".mobile-menu").css({ 'height': "calc(100vh - " + headerHeight + "px)" });
				} else {
					$(".mobile-menu").css({ 'height': '0px' });
				}
			});

			$(".menu-other").click(function (e) {
				e.preventDefault();
				$(this).toggleClass("active");
			});

			$(".menu-other-sub-wrapper").click(function (e) {
				e.stopPropagation();
			});

			$(".product-family-area .container").slick({
				dots: true,
				arrows: false,
				adaptiveHeight: true,
				slidesToShow: 2,
				slidesToScroll: 1,
				adaptiveHeight: true,
				responsive: [
					{
						breakpoint: 625,
						settings: {
							slidesToShow: 1,
							slidesToScroll: 1
						}
					}
				]
			});

		},
		unmatch: function () {
			$(".diffrence-area__item-wrap, .product-family-area .container").slick('unslick');
		},
	});


	// TABS - mertdiricanli
	$('.tabs a').click(function (e) {
		e.preventDefault();
		$('.tabs a').removeClass('active');
		$(this).addClass('active');
		var tab = $(this).attr('href');
		$('.tabcontent .tab').css('display', 'none');
		$(tab).css('display', 'block');
	});

	$('#cart-dynamic').on('click', '.discount-box .dis-option', function () {
		$('.discount-box .dis-option').removeClass('selected');
		$(this).addClass('selected');
		var option = $(this).attr('data-value');
		$('.totals-box li, .totals-box a.primary-button').css('display', 'none');
		$('li' + option).css('display', 'flex');
		$('a.primary-button' + option).css('display', 'block');
	});

});