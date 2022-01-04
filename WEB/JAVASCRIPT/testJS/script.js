var element = document.getElementById("liste");
    element.addEventListener("click", function(){       
    if(element.nextElementSibling.style.display !="block")
    element.nextElementSibling.style.display = "block";    
    else{
        element.nextElementSibling.style.display = "none"
    }

});