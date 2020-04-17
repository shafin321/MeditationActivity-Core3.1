var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {

    dataTable = $('#tblData').dataTable({
        "ajax": {
            //    "url": "/admin/category/GetAll",

            "url": "/meditationApp/GetAll",


            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "created", "width": "20%" },
            { "data": "physicalLoad", "width": "20%" },
            { "data": "mentalStausRate", "width": "20%" },
            { "data": "sleepQuality", "width": "20%" },
            { "data": "physicalStatusRate", "width": "20%" }
           
            


        ],
        "language": {
            "emptyTable": "No records found."
        },
        "width": "100%"
    });
}