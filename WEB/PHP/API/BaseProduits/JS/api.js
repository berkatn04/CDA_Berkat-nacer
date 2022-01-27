const requ = new XMLHttpRequest();
const requ2 = new XMLHttpRequest();
const requ3 = new XMLHttpRequest();
selectCateg = document.getElementById("Categorie")
selectProd = document.getElementById("Produit")




requ.open('POST', 'index.php?page=CategoriesAPI', true);
        requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        requ.send();

requ.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);;
            reponse=JSON.parse(this.responseText); 
            console.log(reponse);
            // for(let i=0;i<reponse.length;i++){
            // document.getElementById("select").innerHTML += reponse[i].libelleProduit + " ";
            // }
            selectCateg.innerHTML = reponse;
           // document.getElementById("sel").innerHTML=reponse;
            

        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};


selectCateg.addEventListener("change", function (){
requ2.open('POST', 'index.php?page=ProduitsAPI', true);
        requ2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        selCateg = document.getElementById("idCategorie")
         var args = "categ="+selCateg.value;
         requ2.send(args);
})

requ2.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);;
            reponse=JSON.parse(this.responseText); 
            console.log(reponse);
            selectProd.innerHTML =reponse;
          
            

        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};


selectProd.addEventListener("change", function (){
    requ3.open('POST', 'index.php?page=DetailsAPI', true);
            requ3.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            selprod = document.getElementById("idProduit")
             var args = "details="+selprod.value;
             requ3.send(args);
    })

    requ3.onreadystatechange = function(event) {
        if (this.readyState === XMLHttpRequest.DONE) {
            if (this.status === 200) {
                console.log("Réponse reçue: %s", this.responseText);;
                reponse=JSON.parse(this.responseText); 
                console.log(reponse);
                selectProd.innerHTML =reponse;
              
                
    
            } else {
                console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
            }
        }
    };