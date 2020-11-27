$(document).ready(function () {
    //Search
    $(document).on("keyup", "#input-search", function () {
        let search = $(this).val().trim();
        $("#searchList li").slice(1).remove();
        if (search.length > 0) {
            $.ajax({
                url: "/Product/Search?search=" + search,
                type: "Get",
                success: function (res) {
                    $("#searchList").append(res);
                }
            })
        }
        
    })

    // HEADER
    //Load more product - partial view
    let skip = 8;
    $(document).on('click', '#loadMore', function () {
        let productCount = $("#ProductCount").val();
        $.ajax({
            url: '/Product/Load?skip='+skip,
            type: 'Get',
            success: function (res) {
                console.log(res);
                $("#productList").append(res)
                skip += 8;
                if (skip >= productCount) {
                    $("#loadMore").remove();
                }
                //OLD Version
                //for (let item of res) {
                //    let divImg = $("<div>").addClass("img");
                //    let a = $("<a>");
                //    let img = $("<img>").addClass("img-fluid").attr("src", "/img/" + item.image);
                //    a.append(img);
                //    divImg.append(a);

                //    let divTitle = $("<div>").addClass("title mt-3");
                //    let h6 = $("<h6>").text(item.title);
                //    divTitle.append(h6);

                //    let divPrice = $("<div>").addClass("price");
                //    let spanCart = $("<span>").addClass("text-black-50").text("Add to cart");
                //    let spanPrice = $("<span>").addClass("text-black-50").text(item.price);
                //    divPrice.append(spanCart, spanPrice);

                //    let divItem = $("<div>").addClass("product-item text-center").attr("data-id", item.category.name);
                //    divItem.append(divImg, divTitle, divPrice);

                //    let divCol = $("<div>").addClass("col-sm-6 col-md-4 col-lg-3 mt-3");
                //    divCol.append(divItem);

                //    $("#productList").append(divCol);
                //}
            }
        })
    })

    $(document).on('click', '#search', function () {
        $(this).next().toggle();
    })

    $(document).on('click', '#mobile-navbar-close', function () {
        $(this).parent().removeClass("active");

    })
    $(document).on('click', '#mobile-navbar-show', function () {
        $('.mobile-navbar').addClass("active");

    })

    $(document).on('click', '.mobile-navbar ul li a', function () {
        if ($(this).children('i').hasClass('fa-caret-right')) {
            $(this).children('i').removeClass('fa-caret-right').addClass('fa-sort-down')
        }
        else {
            $(this).children('i').removeClass('fa-sort-down').addClass('fa-caret-right')
        }
        $(this).parent().next().slideToggle();
    })

    // SLIDER

    $(document).ready(function(){
        $(".slider").owlCarousel(
            {
                items: 1,
                loop: true,
                autoplay: true
            }
        );
      });

    // PRODUCT

    $(document).on('click', '.categories', function(e)
    {
        e.preventDefault();
        $(this).next().next().slideToggle();
    })

    $(document).on('click', '.category li a', function (e) {
        e.preventDefault();
        let category = $(this).attr('data-id');
        let products = $('.product-item');
        
        products.each(function () {
            if(category == $(this).attr('data-id'))
            {
                $(this).parent().fadeIn();
            }
            else
            {
                $(this).parent().hide();
            }
        })
        if(category == 'all')
        {
            products.parent().fadeIn();
        }
    })

    // ACCORDION 

    $(document).on('click', '.question', function()
    {   
       $(this).siblings('.question').children('i').removeClass('fa-minus').addClass('fa-plus');
       $(this).siblings('.answer').not($(this).next()).slideUp();
       $(this).children('i').toggleClass('fa-plus').toggleClass('fa-minus');
       $(this).next().slideToggle();
       $(this).siblings('.active').removeClass('active');
       $(this).toggleClass('active');
    })

    // TAB

    $(document).on('click', 'ul li', function()
    {   
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
        let dataId = $(this).attr('data-id');
        $(this).parent().next().children('p.active').removeClass('active');

        $(this).parent().next().children('p').each(function()
        {
            if(dataId == $(this).attr('data-id'))
            {
                $(this).addClass('active')
            }
        })
    })

    $(document).on('click', '.tab4 ul li', function()
    {   
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
        let dataId = $(this).attr('data-id');
        $(this).parent().parent().next().children().children('p.active').removeClass('active');

        $(this).parent().parent().next().children().children('p').each(function()
        {
            if(dataId == $(this).attr('data-id'))
            {
                $(this).addClass('active')
            }
        })
    })

    // INSTAGRAM

    $(document).ready(function(){
        $(".instagram").owlCarousel(
            {
                items: 4,
                loop: true,
                autoplay: true,
                responsive:{
                    0:{
                        items:1
                    },
                    576:{
                        items:2
                    },
                    768:{
                        items:3
                    },
                    992:{
                        items:4
                    }
                }
            }
        );
      });

      $(document).ready(function(){
        $(".say").owlCarousel(
            {
                items: 1,
                loop: true,
                autoplay: true
            }
        );
      });
})