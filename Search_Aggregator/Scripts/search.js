$(document).ready(function () {
    $.urlParam = function (name) {
        var results = new RegExp('[\?&]' + name + '=([^&#]*)').exec(window.location.href);
        return results[1] || 0;
    }
    $(".nextBtn").on("click", function () {
        var query = $.urlParam('query');
        var page = parseInt($.urlParam('page')) + 1;
        window.location.href = "/Home/Results?query=" + query + "&page=" + page;
    });
    $(".prevBtn").on("click", function () {
        var query = $.urlParam('query');
        var page = parseInt($.urlParam('page'));
        if(page > 1) page = page - 1;
        window.location.href = "/Home/Results?query=" + query + "&page=" + page;
    });
});
