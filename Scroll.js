$(document).ready(function(){
  
  $(window).scroll(function(){
    if($(window).scrollTop() > 100) {
      $(".effect").show().animate({
        opacity: "1"
      }, 10)
    }
  })
  
  
  
})
