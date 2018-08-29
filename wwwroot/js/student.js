$('#searchByName').keyup(function () {
    var obj = { 'name': $('#searchByName').val() };
    //alert(obj);
    $.ajax(
        {
            type: "GET",
            url: "/Home/SearchByName",
            data: obj,
            success: function (response) {
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(response);
                // console.log(response);
            },
            error: function (err) {
                //console.log(err);
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(err.statusText);
            }
        });

});



$('[data-attr="search"]').on('click', function () {
    alert('working');
    var obj = { 'text': $('#searchByInput').val(), 'searchBy': $('#SearchByAttribute  option:selected').val(), 'sortBy': $('#SortByAttribute  option:selected').val() };
    //alert(obj);
    $.ajax(
        {
            type: "GET",
            url: "/Home/Search",
            data: obj,
            success: function (response) {
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(response);
                // console.log(response);
            },
            error: function (err) {
                //console.log(err);
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(err.statusText);
            }
        });
});