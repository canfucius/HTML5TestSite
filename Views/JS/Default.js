$(document).ready(function () {
    //$('#submitText').click(function () {
    //    $('#txtHolder').html('<span>I am like code behind in txtHolder.</span>');
    //    $('#results').html('<span>Results are here today.</span>');
    //});

    $('#mainpage').submit(function (e) {
        e.preventDefault();
        alert("hi");
        var formData = $(this).serialize();
        var frm = $(e.target);
        $.ajax({
            url: "../../Controllers/Default.cshtml",
            data: formData,
            type: "POST",
            dataType: "json",
            success: function (response) {
                alert(response);
                var options3 = $("#options3");
                options3.empty();
                for (var i = 0; i < response.length; i++)
                {
                    options3.append(
                        $("<option></option>").text(response[i]).val(response[i])
                    );
                }
                // Adds data to dropdown
            },
            error: function () {
                alert("Sorry, there seems to be a problem contacting the server.");
            }
        });
    });
});