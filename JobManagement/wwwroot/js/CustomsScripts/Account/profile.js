"use strict";

(function () {

    const primaryStyleClass = 'primary-active';
    const accountBaseUrl = '/User';


    $(document).ready(function () {

        var $btnProfileInfo = $('#btn-profile-info');
        var $btnProfileGallery = $('#btn-profile-gallery');
        var $btnProfileVideo = $('#btn-profile-video');

        var $profileBtns = $('.profile-btn');

        function setStyles($active) {
            $profileBtns.removeClass(primaryStyleClass);
            $active.addClass(primaryStyleClass);
        }

        function loadProfileInfo() {
            window.showLoading();
            setStyles($btnProfileInfo);

            $.get(`${accountBaseUrl}/UserInfo`, function (data) {

                $("#profile-container").html(data);

                window.hideLoading();
            });
        }
        
        function loadProfileGallery() {
            window.showLoading();
            setStyles($btnProfileGallery);

            $.get(`${accountBaseUrl}/UserGallery`, function (data) {
                $("#profile-container").html(data);

                    window.hideLoading();
            });
        }

        function loadProfileVideo() {
            window.showLoading();
            setStyles($btnProfileVideo);

            $.get(`${accountBaseUrl}/UserVideo`, function (data) {

                $("#profile-container").html(data);

                window.hideLoading();
            });
        }

        function eventHandlers() {
           
            $('#btn-profile-info').on('click', function () {
                loadProfileInfo();
              
            });
            $('#btn-profile-gallery').on('click', function () {
                loadProfileGallery();
            });
            $('#btn-profile-video').on('click', function () {
                loadProfileVideo();
            });
        }
        
        eventHandlers();

        //text editors
    
       
    });

    $('#telephone-number').click(function () {
        $(this).find('span').text($(this).data('last'));
    });



}());
