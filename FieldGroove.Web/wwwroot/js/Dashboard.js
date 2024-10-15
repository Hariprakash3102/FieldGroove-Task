$.ajax({
    url: '/Home/Dashboard',
    type: 'GET',
    header: {
        Authentication: "Bearer " + localStorage.getItem("Jwt")
    },
    beforeSend: function (xhr) {
        var token = localStorage.getItem("Jwt");
        if (token) {
            xhr.setRequestHeader("Authorization", "Bearer " + token);
        }
    },
    success: function (response) {
        alert("Success");
    },
    error: function (xhr, status, error) {
        console.error("Error: " + xhr.responseText);
    }
});
