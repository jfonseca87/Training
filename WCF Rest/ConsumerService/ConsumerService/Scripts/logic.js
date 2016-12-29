$(document).ready(function () {
    

    $.ajax({
        url: 'http://localhost:63647/CRUDService.svc/rest/getbooks',
        type: 'GET',
        accept: 'application/json',
        success: function (data) {
            $.each(data, function (i, v) {
                $("#content").append(
                    '<tr><td>' + v.BookId + '</td><td>' + v.Title + '</td><td>' + v.ISBN + '</td><td><a href="javascript:void;" class="editClass" data-id="' + v.BookId + '">Edit </a>|<a href="javascript:void;" class="deleteClass" data-id="' + v.BookId + '"> Delete</a></td></tr>'
                );
            });
        },
        error: function (e) {
            alert("Something went wrong!!!!");
        }
    });

    $("#btnSave").click(function () {
        jQuery.support.cors = true;

        var title = $("#txtTitle").val();
        var isbn = $("#txtISBN").val();

        $.ajax({
            url: 'http://localhost:63647/CRUDService.svc/rest/newbook',
            type: 'POST',
            contentType: 'application/json',
            datatype: 'json',
            data: '{"Title": "' + title + '", "ISBN": "' + isbn + '"}',
            success: function (data) {
                if (data == true)
                {
                    location.href = "/book/index";
                }
            },
            error: function (e) {
                alert("something wrong happens!!!");
            }
        });
    });

    $("#content").on("click", ".editClass", function () {
        var id = $(this).data("id");
        
        $.ajax({
            url: 'http://localhost:63647/CRUDService.svc/rest/getbook/'+ id,
            type: 'GET',
            accept: 'application/json',
            success: function (data) {
                location.href = "http://localhost:51655/book/editbook?bookid=" + data.BookId + "&title=" + data.Title + "&isbn=" + data.ISBN;
            },
            error: function (e) {
                alert("Something went wrong!!!!");
            }
        });
    });

    $("#btnEdit").click(function () {
        
        var bookId = $("#BookId").val();
        var title = $("#Title").val();
        var isbn = $("#ISBN").val();

        $.ajax({
            url: 'http://localhost:63647/CRUDService.svc/rest/editbook',
            type: 'POST',
            contentType: 'application/json',
            datatype: 'json',
            data: '{"BookId":"' + bookId + '","Title": "' + title + '", "ISBN": "' + isbn + '"}',
            success: function (data) {
                if (data == true) {
                    location.href = "/book/index";
                }
            },
            error: function (e) {
                alert("Something is wrong!!!");
            }
        });
    });

    $("#content").on("click", ".deleteClass", function () {
        var id = $(this).data("id");
        
        if (!confirm('Esta seguro(a) de eliminar el libro de la base?')) {
            return false;
        }
        else
        {
            $.ajax({
                url: 'http://localhost:63647/CRUDService.svc/rest/delbook',
                type: 'POST',
                contentType: 'application/json',
                datatype: 'json',
                data: '{"id":"' + id + '"}',
                success: function (data) {
                    location.reload();
                },
                error: function (e)
                {
                    alert("Something is wrong!!!");
                }
            });
        }
    });

});