function ajaxLogin() {
    var $form = $("#LoginForm");
    var email = $('#Email', $form).val(); 

    $.ajax({
        url: '/Login/Login',
        type: "POST",
        data: {
            Email: email,
            Password: $('#Password', $form).val()
        }, 
        
        success: function (response) {
            if (response.success) {
                localStorage.setItem("Jwt", response.message);
                $.ajax({
                    url: '/Home/Dashboard',
                    type: 'GET',
                    headers: {
                        "Authorization": "Bearer " + localStorage.getItem("Jwt")
                    },
                    success: function (response) {
                        $('body').html(response);
                        window.history.pushState({},'','/Home/Dashboard');
                    }
                });
            } else {
                $("#LoginError").html("<p class='text-danger'>" + response.message + "</p>");
            }
        },
        error: function (xhr, status, error) {
            $("#LoginError").html("<p class='text-danger'>An error occurred: " + xhr.responseText + "</p>");
        }
    });
    return false;
}

