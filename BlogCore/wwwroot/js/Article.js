let datatable;

$(document).ready(function () {
    loadDataTable();
});


function Delete(url) {
    swal({
        title: "Esta seguro de borrar?",
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
    datatable = $("#tblArticulos").DataTable({
        "ajax": {
            "url": "/admin/article/GetAll",
            "type": "GET",
            "dataType": "json"
        },
        "columns": [
            { "data": "id", "witdth": "5%" },
            { "data": "name", "witdth": "25%" },
            { "data": "category.name", "witdth": "20%" },
            { "data": "createDate", "witdth": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="row">
                                <a href="/admin/article/edit/${data}" class="btn btn-success text-white" style="cursor:pointer"> 
                                    <i class="fa fa-edit"></i> Editar
                                </a> &nbsp;
                                <a  onclick=Delete("/admin/article/delete/${data}") class="btn btn-danger text-white" style="cursor:pointer "> 
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

