$(document).ready(function () {
    $("#myTable").dataTable({
        ordering: false,
        searching: false,
        language: {
            processing: "Procesando...",
            lengthMenu: "Mostrando _MENU_ Registros",
            info: "",
            infoEmpty: "No hay registros",
            infoPostFix: "",
            loadingRecords: "Cargando...",
            zeroRecords: "No hay registros",
            paginate: {
                previous: "",
                next: "",
            },
        }
    });
});