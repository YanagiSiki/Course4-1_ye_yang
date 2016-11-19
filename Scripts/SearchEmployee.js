$(document).ready(function () {

    $(".btnDelete").click(function (e) {
        var confirmbox = confirm("確定要刪除?");
        if (confirmbox == true) {
            var tr = $(this).closest('tr')
            $.ajax({
                type: "POST",
                url: "/Employee/DeleteEmployee",
                data: "EmployeeID=" + $(this).next().val(),
                dataType: "json",
                success: function (response) {
                    $(tr).remove();
                    alert("刪除成功");
                }
            });
        }         
        return false;
    });

    $("#clearbtn").click(function () {        
        $("#Form")[0].reset();
        $("#SelectTitle").val(0);
    });

    $("#newbtn").click(function () {
        window.location.replace("InsertEmployee");
    });

})