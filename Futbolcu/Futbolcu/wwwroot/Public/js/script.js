let onOff = false;



$(document).ready(function () {
   
        $(".gn-icon-menu").click(function () {
            if (!onOff) {
                $(".gn-menu-wrapper").css("left", "-200px");
                onOff = true;
                console.log("true");
            }
            else {
                $(".gn-menu-wrapper").css("left", "60px");
                onOff = false;
                console.log("false");
            }
        });
    
   
    
});
 
 