// Utilisation de l'Ajax pour appeler l'API et récuperer les enregistrements
var contenu = document.getElementById("contenu");
var enregs; // contient la reponse de l'API
// on définit une requete
const req = new XMLHttpRequest();

reqText = "http://api.openweathermap.org/data/2.5/weather?lang=FR&units=metric&appid=2aa0b2edb1413f48d09e184a8d90f8ba&q="
//on envoi la requête

document.getElementById("villeCherchee").addEventListener("change",function(){
    req.open('GET', reqText+this.value, true);
    req.send(null);
})


//on vérifie les changements d'états de la requête
req.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            document.getElementById("ville").textContent = reponse.name;
            document.getElementById("temp").textContent = reponse.main.temp;
            document.getElementById("wind").textContent=reponse.wind.speed;
    } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

