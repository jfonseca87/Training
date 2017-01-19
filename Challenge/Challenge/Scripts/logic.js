$(document).ready(function () {
    $("#btnGuardar").click(function () {
        
        var bookid, title, isbn;
        var datos = "[";

        var cont = $("#content tr").length;

        $("#content tr").each(function (k, v) {
            $(this).children("td").each(function (q, r) {
                switch (q)
                {
                    case 0: bookid = $(r).html();
                        break;
                    case 1: title = $(r).html();
                        break;
                    case 2: isbn = $(r).html();
                        break;
                }
            });

            datos += '{"BookId": "' + bookid + '", "Title": "' + title + '", "ISBN":"' + isbn + '"}';

            if (k != cont - 1)
            {
                datos += ", ";
            }

        });

        datos += "]";

        $.ajax({
            url: "/book/index",
            type: "POST",
            contentType: "application/json",
            datatype: "json",
            data: datos,
            success: function (data) {

            },
            error: function (e) {

            }
        });
    });
});