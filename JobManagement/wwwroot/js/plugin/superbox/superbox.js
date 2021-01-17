/*
	SuperBox v1.0.0 (modified by bootstraphunter.com)
	by Todd Motto: http://www.toddmotto.com
	Latest version: https://github.com/toddmotto/superbox
	
	Copyright 2013 Todd Motto
	Licensed under the MIT license
	http://www.opensource.org/licenses/mit-license.php

	SuperBox, the lightbox reimagined. Fully responsive HTML5 image galleries.
*/
;
(function($) {

    $.fn.SuperBox = function(options) {

        var superbox = $('<div class="superbox-show"></div>'),
            superboximg =
                $(
                    '<img src="" class="superbox-current-img">'),
            superboxclose = $('<div class="superbox-close txt-color-white"><i class="fa fa-times fa-lg"></i></div>');

        superbox.append(superboximg).append(superboxclose);

       

        return this.each(function() {
            debugger;
            $(".superbox-list").click(function() {
                //$('.superbox-list', $(this)).click(function() {
                $this = $(this);

                var currentimg = $this.find(".superbox-img"),
                    imgData = currentimg.attr('src'),
                    imgDescription = currentimg.attr("alt") || "No description",
                    imgLink = imgData;

                //console.log(imgData, imgDescription, imgLink, imgTitle)

                superboximg.attr("src", imgData);

                $(".superbox-list").removeClass("active");
                $this.addClass("active");

                
                superboximg.find("em").text(imgLink);

                //console.log("fierd")

                if ($(".superbox-current-img").css("opacity") == 0) {
                    $(".superbox-current-img").animate({ opacity: 1 });
                }

                if ($(this).next().hasClass("superbox-show")) {
                    if (superbox.is(":visible"))
                        $(".superbox-list").removeClass("active");
                    superbox.toggle();
                } else {
                    superbox.insertAfter(this).css("display", "block");
                    $this.addClass("active");
                }

                var emptySpace = '400px';

                debugger ;
                $("html, body").animate({
              
                    scrollTop: currentimg.offset().top - currentimg.height()/2
                    },
                    "medium");

            });

            $(".superbox").on("click",
                ".superbox-close",
                function() {
                    $(".superbox-list").removeClass("active");
                    $(".superbox-current-img").animate({ opacity: 0 },
                        200,
                        function() {
                            $(".superbox-show").slideUp();
                        });
                });

        });
    };
})(jQuery);
