var dataTable;

$(document).ready(function () {
    loadList();
});

function loadList() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/abstractrating/",
            "type": "GET",
            "datatype": "json"
        },
        "order": [[3, "asc"],[4, "asc"]],
        "columns": [
            { "data": "id", "width": "5%" },
            {
                "data": "title",
                "render": function (data, type, row) {
                    return `<a href="${row.docPath}" target="_blank">${data}</a>`
                },
                "width": "35%"
            },
            { "data": "author", "width": "20%" },
            { "data": "rateCount", "width": "10%" },
            { "data": "rating.avgRating", "defaultContent": "", "width": "15%" },
            {
                "data": "rating.id",
                "defaultContent": "0",
                "render": function (data, type, row) {
                    if (data == null) {
                        return `<div class="text-center">
                                <a href="./abstractrating/upsert?ratingId=${data}&abstractId=${row.id}" class="btn btn-success text-white" style="cursor:pointer; width:100px;">
                                    <i class="far fa-edit"></i> Rate
                                </a>
                                </div>`;
                        
                    } else {
                        
                        return `<div class="text-center">
                                <a href="./abstractrating/upsert?ratingId=${data}&abstractId=${row.id}" class="btn btn-secondary text-white" style="cursor:pointer; width:100px;">
                                    <i class="fas fa-list-alt"></i> Review
                                </a>
                                </div>`;
                    }
                    
                },
                "width": "15%"
            }
        ],
        "language": {
            "emptyTable": "no data found."
        },
        "width": "100%"
    });
};

function Delete(url) {
    swal({
        title: "Are you sure you want to Delete?",
        text: "You will not be able to restore the data!",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}
