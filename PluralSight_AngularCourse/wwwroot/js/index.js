$(document).ready(function () {

    console.log("JS file loaded!")

    var theForm = $("#theForm");
    theForm.hide();

    var button = $("#buyButton");
    button.on("click", function () {
        console.log("User Clicked Buy Button")
    })

    var productInfo = $(".products-props li");
    productInfo.on("click", function () {
        consoel.log("Ya clicked on " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.slideToggle(30);
    });

});

