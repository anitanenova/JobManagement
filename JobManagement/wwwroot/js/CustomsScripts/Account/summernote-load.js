    /* DO NOT REMOVE : GLOBAL FUNCTIONS!
 *
 * pageSetUp(); WILL CALL THE FOLLOWING FUNCTIONS
 *
 * // activate tooltips
 * $("[rel=tooltip]").tooltip();
 *
 * // activate popovers
 * $("[rel=popover]").popover();
 *
 * // activate popovers with hover states
 * $("[rel=popover-hover]").popover({ trigger: "hover" });
 *
 * // activate inline charts
 * runAllCharts();
 *
 * // setup widgets
 * setup_widgets_desktop();
 *
 * // run form elements
 * runAllForms();
 *
 ********************************
 *
 * pageSetUp() is needed whenever you load a page.
 * It initializes and checks for all basic elements of the page
 * and makes rendering easier.
 *
 */

    pageSetUp();

    // PAGE RELATED SCRIPTS

    // pagefunction

    var pagefunction = function() {

        // summernote
        $('#summernote').summernote({
            height: 200,
            theme: 'paper',
            toolbar: [
                ['style', ['style']],
                ['font', ['bold', 'italic', 'underline', 'clear']],
                ['fontname', ['fontname']],
                ['color', ['color']],
                ['para', ['ul', 'ol', 'paragraph']],
                ['height', ['height']],
                ['table', ['table']],
                ['insert', ['link', 'picture', 'hr']],
                ['view', ['fullscreen', 'help']]
            ]
        });

    };

    // end pagefunction

    // destroy generated instances
    // pagedestroy is called automatically before loading a new page
    // only usable in AJAX version!

    var pagedestroy = function() {

        // destroy summernote
        $(".summernote").summernote();

    };

    // end destroy

    // load summernote, and all markdown related plugins
    loadScript("/js/plugin/summernote/summernote.min.js",
        function() {
            loadScript("/js/plugin/markdown/markdown.min.js",
                function() {
                    loadScript("/js/plugin/markdown/to-markdown.min.js",
                        function() {
                            loadScript("/js/plugin/markdown/bootstrap-markdown.min.js", pagefunction);
                        });
                });
        });

