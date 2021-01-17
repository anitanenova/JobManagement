//////////////SHOW GLOBAL LOADING
function showLoading() {
  $('#loading').show();
}
//////////////HIDE GLOBAL LOADING
function hideLoading() {
  $('#loading').hide();
}
//////////////SHOW LOCAL LOADING
function showLoaderInEl(el) {
    $(el).append('<div class="custom-loader"><div class="lds-roller"><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div></div>');
}

//////////////HIDE LOCAL LOADING
function hideLoaderInEl(el) {
    $(el).find('.custom-loader').remove();
}


////////////////////////customParams///////////
var CustomParam = function (key, value) {
    this.key = key;
    this.value = value;
}

function getParamsQuery(params) {
    var paramsQuery = "";

    if (params == null) {
        return paramsQuery;
    }

    for (var i = 0; i < params.length; i++) {
        paramsQuery += "&" + params[i].key + "=" + params[i].value;
    }
    return paramsQuery;
}



///////////////////////////INFINITY SCROLL
var setInfinityScroll = function (obj) {
    debugger;

    var take = obj.take,
        isLoading = false;


    var ulEl = $(obj.ulElSelector);

    var isWindowScroll = obj.isWindowScroll;

    var loaderCont = ulEl;

    /////////////////////////////////////////////COUNT ALL CURRENT LISTED ELEMENTS
    function setSkip() {
        return parseInt(ulEl.children('li').length);
    }

    function loadEjectedElements(skip, take) {
        debugger;
        var isAllDataLoaded = parseInt(ulEl.attr('data-all'));
        var isSearching = parseInt(ulEl.attr('data-searching'));
        if (isLoading || isAllDataLoaded == 1 || isSearching == 1) {
            return false;
        }


        showLoaderInEl("#" + loaderCont.attr("id"));
        $('.spinner').css('top', 'auto');

        isLoading = true;
        var search = $(obj.searchInput).val();


        var url = obj.url + "?skip=" + skip + "&take=" + take + "&searchString=" + search;

        if (obj.customParameters != null && obj.customParameters.length > 0) {

            for (var i = 0; i < obj.customParameters.length; i++) {
                url += "&" + obj.customParameters[i].parameterName + "=" + $(obj.customParameters[i].fieldSelector).val();
            }
        }

        $.ajax({
            url: url,
            cache: false,
            success: function (html) {

                ulEl.append(html);

                if (html.trim().length == 0 || html.trim().length == "") {
                    ulEl.attr('data-all', 1);
                }

                isLoading = false;

                hideLoaderInEl(loaderCont);
                //if (isWindowScroll) {
                //    hideLoading();
                //} else {

                //}
            }
        });
    }

    bindInfinityScroll(obj.scrolledEl, function () { loadEjectedElements(setSkip(), take); }, isWindowScroll);
}


////////////////ADD SCROLL EVENT TO UL ELEMENT
function bindInfinityScroll(el, func, isWindowScroll) {
    debugger;


    if (isWindowScroll) {
        $(el).on('scroll', function () {
            if ($(window).scrollTop() > $(document).height() - $(window).height() - 100) {
                func();
            }
        });
    } else {
        $(el).on('scroll', function () {
            if ($(this).scrollTop() + $(this).innerHeight() >= $(this)[0].scrollHeight - 100) {
                func();
            }
        });
    }
}




////////////////////////////////////////RESIZE ELEMENTS
function resize(obj) {

    //console.log(obj.el);
    //var elHeight = $(obj.el).height();
    var windowInner = window.innerHeight;

    var newHeight = windowInner - obj.bottom;
    //if (obj.firstHeight > newHeight) {
    $(obj.el).height(newHeight);

    // $(obj.el).animate({ 'opacity': '1'}, 1000, function () {
    //});
    //}
    $(window).one('resize', function (e) {
        resize(obj);
    });
}
