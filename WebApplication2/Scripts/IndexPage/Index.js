$(".btnClick").click(function () {
    var tempId = this.id;
    $.ajax({
        url: "/api/Shops/" + this.id,
        type: "GET",
        dataType: "json",
        success: function (data) {
            var content = document.getElementsByClassName("content");
            for (var i = 0; i < content.length; i++) {
                var contentValue = +content[i].innerHTML.replace(/\D+/g, "");
                if (contentValue === +tempId) {
                    content[i].innerHTML = "";
                    $(content[i]).append(
                        '<table class="table">' +
                        "<tr>" +
                        "<th>" +
                        "Название товара" +
                        "</th>" +
                        "<th>" +
                        "Описание товара" +
                        "</th>" +
                        "</tr>" +
                        "</table>");
                    for (var x = 0; x < data.length; x++) {
                        $(content[i]).append(
                            "<tr>" + "<td>" + data[x].Name + "</td>" + "<td>" + data[x].Description + "</td>" + "</tr>" + "<tr>" + "</tr>");
                    }
                }
            }
        },
        error: function (data) {
            alert("Error:" + data);
        }
    });
})