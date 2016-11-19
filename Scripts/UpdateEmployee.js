$(document).ready(function () {
    $("#backbtn").click(function () {
        window.location.replace("../SearchEmployee");
    });


    $("#btnDelete").click(function (e) {
        var confirmbox = confirm("確定要刪除?");
        var empid = $("#Number").val();
        if (confirmbox == true) {
            $.ajax({
                type: "POST",
                url: "/Employee/DeleteEmployee",
                //data: "orderId=" + $(this).next().val(),
                data: { EmployeeID: empid },
                dataType: "json",
                success: function (response) {
                    alert("刪除成功");
                    window.location.replace("../SearchEmployee");
                }
            });
        }        
        return false;
    });

    $("#MonthlyPayment").keyup(function () {
        $("#YearlyPayment").val($("#MonthlyPayment").val() * 14);

    });
   
})