const message = $("#message");

$("#number").on("input", function () {
    let $this = $(this);

    let url = $this.data("url");
    let number = $this.val();

    // if nothing input, return to waiting
    if (!number) {
        message.removeClass("alert-danger alert-success")
            .addClass("alert-info")
            .text(message.data("default"));
    }

    $.post(url, { number: number }, function (result) {
        if (result) {
            message.removeClass("alert-danger alert-info")
                .addClass("alert-success")
                .text("Yes! It is a palindrome!");
        }
        else {
            message.removeClass("alert-success alert-info")
                .addClass("alert-danger")
                .text("No! Not a palindrome!");
        }
    });
});