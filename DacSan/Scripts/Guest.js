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