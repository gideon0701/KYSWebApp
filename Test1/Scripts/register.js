$(document).ready(function () {
    //$(".private").hide()
    $(".other").hide()
    $("#first").prop("checked",true)

    $('.documentUpld').on('change', function () {
        //alert(this.value == 0);
        if (this.value == 0) {
            $(".private").show()
            $(".other").hide()
        } else {
            $(".other").show()
            $(".private").hide()
        }
    });

});