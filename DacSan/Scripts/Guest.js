$(function () {
    $('a#btn-search-modal').click(function () {

        $('#searchmodal').modal({
            backdrop: 'static',
            keyboard: false,
            show: true
        });

        $('#searchmodal').on('shown.bs.modal', function () {
            $('#search-product input[name="key"]').focus();
        });
        return false;
    });
})

        $(function () {
            $('.btn-menu-mobile').click(function () {
                id = $(this).attr('data-menu');
                $(id).toggleClass('open');
            });
            $('.btn-close').click(function () {
                $(this).parent().toggleClass('open');
            });

            $('.arrow-sub-vmenu').click(function () {
                $(this).find('.fa').toggleClass('fa-angle-down');
            });
        });


var revapi, revcf, w_width;
w_width = $(window).width();
revcf = {
    delay: 5000,
    startheight: 400,
    hideThumbs: 10
}

$(document).ready(function () {

    revcf.startheight = 400;

    if (w_width < 868) revcf.startheight = 400;

    if (w_width < 668) revcf.startheight = 300;

    revapi = jQuery('.tp-banner').revolution(revcf);
}); //ready


$(document).ready(function () {
    // vertical('#widget_post_left_38', 3000, 4);
    $("#widget_post_right_38").owlCarousel({
        items: 2,
        margin: 10,
        loop: true,
        autoplay: true,
        autoplayTimeout: 2000,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 1
            },
            400: {
                items: 2
            },
            600: {
                items: 2
            },
            1000: {
                items: 2
            }
        }
    });

    $(".item-video").click(function () {
        $('#video-main').attr('src', 'https://www.youtube.com/embed/' + $(this).attr('href'));
        return false;
    });
});

$(document).ready(function () {
    $("#widget_post_39").owlCarousel({
        items: 3,
        margin: 10,
        loop: true,
        autoplay: true,
        autoplayTimeout: 2000,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 2
            },
            400: {
                items: 2
            },
            600: {
                items: 3
            },
            1000: {
                items: 3
            }
        }
    });
});

$(document).ready(function () {
    var ol = $("#owl-partner-46").owlCarousel({
        items: 6,
        margin: 10,
        loop: true,
        autoplay: true,
        autoplayTimeout: 5000,
        autoplayHoverPause: true,
        smartSpeed: 3000,
        responsive: {
            0: {
                items: 2
            },
            400: {
                items: 2
            },
            700: {
                items: 3
            },
            1000: {
                items: 6
            }
        }
    });
});

(function () {
    var pname = ((document.title != '') ? document.title : ((document.querySelector('h1') != null) ? document.querySelector('h1').innerHTML : ''));
    var ga = document.createElement('script');
    ga.type = 'text/javascript';
    ga.async = 1;
    ga.src = '//live.vnpgroup.net/js/web_client_box.php?hash=717a500990eeecbea77b6db2dc3e05ae&data=eyJzc29faWQiOjEyMDc5MDMsImhhc2giOiJhNWU0ZmUzNmUxYTAyMjk5M2Q0Zjg0Mzg0ZmRlNzU3ZiJ9&pname=' + pname;
    var s = document.getElementsByTagName('script');
    s[0].parentNode.insertBefore(ga, s[0]);
})();