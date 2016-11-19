$(document).ready(function () {
    $("#backbtn").click(function () {
        window.location.replace("SearchEmployee");
    });
    
    $("#MonthlyPayment").keyup(function () {       
        $("#YearlyPayment").val($("#MonthlyPayment").val() * 14);

    });
})