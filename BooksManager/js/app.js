$("#btnLogin").click(function (e) {

    var data = {
        user: $("#txtUser").val(),
        pass: $("#txtPass").val()
    }

    $.ajax({
        url: "/default.aspx/Login",
        type: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function (response) {
            alert(response.d);
        }

    });
});