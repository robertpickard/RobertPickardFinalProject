var dataTable;

$(document).ready(function () {
    loadList();
});

function loadList() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/abstractreview/",
            "type": "GET",
            "datatype": "json"
        },
        "order": [[5, "desc"],[3, "desc"]],
        "columns": [
            { "data": "id", "width": "5%" },
            {
                "data": "title",
                "render": function (data, type, row) {
                    return `<a href="${row.docPath}" target="_blank">${data}</a>`
                },
                "width": "25%"
            },
            { "data": "author", "width": "20%" },
            { "data": "rateCount", "width": "10%" },
            { "data": "rating", "width": "15%" },
            {
                "data": "approved",
                "render": function (data, type, row) {
                    if (data == true && row.date != null) {
                        return `<div class="text-center">
                                    <i class="fas fa-check"></i>
                                </div>`;

                    } else if (data == false && row.date != null) {

                        return `<div class="text-center">
                                    <i class="fas fa-times"></i>
                                </div>`;
                    } else {
                        return `<div class="text-center">
                                    <i class="text-secondary">Pending</i>
                                </div>`;
                    }
                      

                },
                "width": "10%"
            },
            {
                "data": "id",
                "render": function (data, type, row) {
                    if (row.date == null) {
                        return `<div class="text-center">
                                <a href="./abstractreview/upsert?id=${data}" class="btn btn-success text-white" style="cursor:pointer; width:100px;">
                                    <i class="far fa-edit"></i> Review
                                </a>
                                </div>`;
                        
                    } else {
                        
                        return `<div class="text-center">
                                <a href="./abstractreview/upsert?id=${data}" class="btn btn-secondary text-white" style="cursor:pointer; width:100px;">
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
