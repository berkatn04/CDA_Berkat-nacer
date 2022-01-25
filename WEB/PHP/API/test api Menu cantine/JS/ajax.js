// Utilisation de l'Ajax pour appeler l'API et récuperer les enregistrements
var contenu = document.getElementById("contenu");
var enregs; // contient la reponse de l'API
// on définit une requete
const req = new XMLHttpRequest();
const req2 = new XMLHttpRequest();

reqText2 = "https://opendata.lillemetropole.fr/api/records/1.0/search/?dataset=menu-cantine&rows=1&facet=date&facet=periode&facet=plat_1&facet=desserts_1&q="
reqText = "https://opendata.lillemetropole.fr/api/records/1.0/search/?dataset=menu-cantine&rows=20&facet=date&facet=periode&facet=plat_1&facet=desserts_1&q="
req.open('GET', reqText, true);
req.send(null);

//on vérifie les changements d'états de la requête
req.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            reponse = JSON.parse(this.responseText);
            enregs = reponse.records;
            for (let i = 0; i < enregs.length; i++) {
                // on crée la ligne et les div internes
                // je recupere le template
                var templLigne = document.getElementById("ligne");
                // on clone le template pour avoir une nouvelle structure
                nouvElt = templLigne.content.cloneNode(true);
                //ajoute à la stucture
                contenu.appendChild(nouvElt);
                ligne = contenu.querySelectorAll(".ligne")[i];
                ligne.id = i;
                plat = ligne.querySelector(".plat");
                date = ligne.querySelector(".date");
                dessert = ligne.querySelector(".dessert");
                periode = ligne.querySelector(".periode");
                espace = document.getElementById("espace");
                contenu.appendChild(espace.content.cloneNode(true));
                //on met à jour le contenu
                plat.innerHTML = enregs[i].fields.plat_1;
                date.innerHTML = enregs[i].fields.date;
                dessert.innerHTML = enregs[i].fields.desserts_1;
                periode.innerHTML = enregs[i].fields.periode;

                var selection = document.getElementById("selection");
                var option = document.createElement("option");
                selection.appendChild(option);
                option.setAttribute("value", enregs[i].fields.date );
                option.innerText = enregs[i].fields.date;
            
            }
            selection.addEventListener("change",function(){
                texte = selection.value ;
                req.open('GET', reqText+texte, true);
                req.send(null);
                for (let i=1; i<enregs.length;i++){
                    ligne.setAttribute("class", "hidden");
                }

            })

            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};



