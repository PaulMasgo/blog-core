let datatable;

$(document).ready(function () {
    loadDataTable();
});


function Delete(url) {
    swal({
        title: "¿Esta seguro de borrar?",
        text: "Este contenido no se puede recuperar",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Si, Borrar!",
        closeOnconfirm: true
    }, function () {
        $.ajax({
            type: "DELETE",
            url: url,
            success: function (data) {
                if (data.success) {
                    toastr.success(data.message);
                    datatable.ajax.reload();
                } else {
                    toastr.error(data.message);
                }
            }
        });
    }
    )
};


function loadDataTable() {
    datatable = $("#tblSliders").DataTable({
        "ajax": {
            "url": "/admin/slider/GetAll",
            "type": "GET",
            "dataType": "json"
        },
        "columns": [
            { "data": "id", "witdth": "5%" },
            { "data": "name", "witdth": "50%" },
            {
                "data": "state",
                "render": function (data) {
                    if (data) {
                        return "Activo"
                    }
                    return "Inactivo"
                },
                "witdth": "10%"
            },
            { "data": "urlImage", "witdth": "50%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="row">
                                <a href="/admin/slider/edit/${data}" class="btn btn-success text-white" style="cursor:pointer"> 
                                    <i class="fa fa-edit"></i> Editar
                                </a> &nbsp;
                                <a  onclick=Delete("/admin/slider/delete/${data}") class="btn btn-danger text-white" style="cursor:pointer "> 
                                    <i class="fa fa-trash"></i> Eliminar
                                </a> &nbsp;
                            </div>`
                }, "width": "30%"
            }
        ],
        "languaje": {
            "emptyTable": "No hay registros"
        },
        "with": "100%"

    })
};

