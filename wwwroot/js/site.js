// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



//$(".card-img-top").hover(function () {
//    /*$(".card-img-top").parent().children(".container-img-variant").toggleClass("max-height-container")*/
//        console.log(this)
//    }
//)

$(".main-image-article").hover(function () {
    $(this).children().parent().children(".container-img-variant").toggleClass("max-height-container")
})

function setVariantData(element) {
    var src = $(element).attr("src")
    var articleName = $(element).attr("data-article-name")
    var price = $(element).attr("data-article-price")
    var discountPrice = $(element).attr("data-article-discount-price")
    src = src.replace("100", "300")

    $(element).parent().parent().children("img").attr("src", src)
    $(element).parent().parent().parent().children(".card-body").children(".article-name").text(articleName)
    $(element).parent().parent().parent().children(".card-body").children(".prezzo-articolo").text(price)
    if (discountPrice != 0) {
        $(element).parent().parent().parent().children(".card-body").children(".prezzo-scontato").removeClass("d-none")
        $(element).parent().parent().parent().children(".card-body").children(".prezzo-scontato").text(discountPrice)
    }
    else {
        $(element).parent().parent().parent().children(".card-body").children(".prezzo-scontato").addClass("d-none")
    }
}

function resetVariantData(element) {
    var mainSrc = $(element).attr("data-article-img")
    var articleName = $(element).parent().parent().attr("data-article-name")
    var price = $(element).parent().parent().attr("data-article-price")
    var discountPrice = $(element).parent().parent().attr("data-article-discount-price")
    $(element).parent().parent().children("img").attr("src", mainSrc)
    $(element).parent().parent().parent().children(".card-body").children(".article-name").text(articleName)
    $(element).parent().parent().parent().children(".card-body").children(".prezzo-articolo").text(price)
    if (discountPrice != 0)
    {
        $(element).parent().parent().parent().children(".card-body").children(".prezzo-scontato").removeClass("d-none")
        $(element).parent().parent().parent().children(".card-body").children(".prezzo-scontato").text(discountPrice)
    }
    else
    {
        $(element).parent().parent().parent().children(".card-body").children(".prezzo-scontato").addClass("d-none")
    }
}

//function instantResetImg(mainSrc, element) {
//    clearTimeout()
//    $(element).parent().parent().children("img").attr("src", mainSrc)

//}