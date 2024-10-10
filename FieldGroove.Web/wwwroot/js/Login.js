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
                    // Redirect on successful login
                    window.location.href = "/Home/Dashboard";
                } else {
                    // Show error message 
                    $("#LoginError").html("<p class='text-danger'>" + response.message + "</p>");
                }
            },
            error: function (xhr, status, error) {
                $("#LoginError").html("<p class='text-danger'>An error occurred: " + xhr.responseText + "</p>");
            }
        });
    return false;
}
   
