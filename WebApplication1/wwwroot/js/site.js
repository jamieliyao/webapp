// Write your JavaScript code.
function page1() {
    $.ajax({
        url: "/home/Page2",
        contentType: "texthtml",
        success: function (html) {
            $("#content").html(html);
        }
    })
}

function serverCon() {
    $.ajax({
        url: "/home/serverCon",
        contentType: "texthtml",
        success: function (html) {
            $("#content").html(html);
        }
    })
}
function servicesPriCon() {
    $.ajax({
        url: "/home/servicesPriCon",
        contentType: "texthtml",
        success: function (html) {
            $("#content").html(html);
        }
    })
}
function LogCon() {
    $.ajax({
        url: "/home/LogCon",
        contentType: "texthtml",
        success: function (html) {
            $("#content").html(html);
        }
    })
}
function serverCon() {
    $.ajax({
        url: "/Home/serverCon",
        contentType: "texthtml",
        success: function (html) {
            $("#content").html(html);
        }
    })
}


      