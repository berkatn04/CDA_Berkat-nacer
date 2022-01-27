var contenu = document.querySelector(".contenu");
var selection = document.getElementById("selection");
var select = document.getElementById("ville");
const requ = new XMLHttpRequest();
const requ2 = new XMLHttpRequest();

/**** GET */
requ.open('GET', 'https://localhost:5001/api/Departements', true);
requ.send();

selection.addEventListener("change", function(){
requ2.open('GET', 'https://localhost:5001/api/Villes/' + selection.selectedIndex, true);
requ2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
requ2.send();
});

/**** GET by ID  */
// requ.open('GET', 'https://localhost:5001/api/Departements/1', true);
// requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ.send();


// /**** POST */
// requ.open('POST', 'https://localhost:5001/api/Departements', true);
// requ.setRequestHeader("Content-Type", "application/json");
// var args={
//     "idDepartement": 0,
//     "libelle": "nouveau"
//   }
//   requ.send(JSON.stringify(args));

//   /**** PUT */
//   requ.open('PUT', 'https://localhost:5001/api/Departements/1', true);
//   requ.setRequestHeader("Content-Type", "application/json");
//   var args={
//       "idDepartement": 1,
//       "libelle": "test"
//     }
//     requ.send(JSON.stringify(args));


// /**** Delete  */
// requ.open('DELETE', 'https://localhost:5001/api/Departements/4', true);
// requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ.send();


requ.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);;
            console.log(this.responseText);
            reponse=JSON.parse(this.responseText);
            var option = document.createElement("option");
            option.setAttribute("value" , "Choississez une valeur");
            option.innerText = "Choississez une valeur";
            selection.appendChild(option);
            for(let i=0 ; i< reponse.length; i++){
                var option2 = document.createElement("option"); 
                option2.setAttribute("value", reponse[i].libelle );
                option2.innerText = reponse[i].libelle;
                selection.appendChild(option2);
            }
            
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};


requ2.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);;
            console.log(this.responseText);
            reponse=JSON.parse(this.responseText);
            var option = document.createElement("option");
            option.setAttribute("value" , "Choississez une valeur");
            option.innerText = "Choississez une valeur";
            select.appendChild(option);
            for(let i=0 ; i< reponse.length; i++){
                var option2 = document.createElement("option"); 
                option2.setAttribute("value", reponse[i].nomVille );
                option2.innerText = reponse[i].nomVille;
                select.appendChild(option2);
            }   
            
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};