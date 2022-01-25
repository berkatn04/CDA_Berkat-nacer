
           req.onreadystatechange = function (event) {


            if (this.readyState === XMLHttpRequest.DONE) {
                if (this.status === 200) {
                    reponse = JSON.parse(this.responseText);
        
                    if (reponse.length == 0) {
                        message.textContent = "Aucun resultat disponible ou le departement " + dep.value + " n'existe pas."
                    } else {
                        while (section.firstChild) {
                            section.removeChild(section.firstChild);
                            message.textContent = "";
                        };
                        message.textContent = reponse.length + " resultat(s) disponible pour le departement " + dep.value;
                        for (let i = 0; i < reponse.length; i++) {
        
                            ligne = document.createElement("div");
                            console.log(ligne);
                            ligne.setAttribute("class", "ligne");
                            console.log(ligne);
                            console.log(reponse[i]);
        
                            elm = document.createElement("div");
                            elm.setAttribute("class", "elm");
                            elm.innerHTML = reponse[i].nom;
                            ligne.appendChild(elm);
        
                            elm = document.createElement("div");
                            elm.setAttribute("class", "elm");
                            elm.innerHTML = reponse[i].prenoms;
                            ligne.appendChild(elm);
        
                            elm = document.createElement("div");
                            elm.setAttribute("class", "elm");
                            elm.innerHTML = reponse[i].filiere;
                            ligne.appendChild(elm);
        
                            elm = document.createElement("div");
                            elm.setAttribute("class", "elm");
                            elm.innerHTML = reponse[i].option;
                            ligne.appendChild(elm);
        
                            elm = document.createElement("div");
                            elm.setAttribute("class", "elm");
                            elm.innerHTML = reponse[i].departement;
                            ligne.appendChild(elm);
        
                            elm = document.createElement("div");
                            elm.setAttribute("class", "elm");
                            elm.innerHTML = reponse[i].resultat;
                            ligne.appendChild(elm);
        
                            section.appendChild(ligne);
                        }
                    }
        
                    console.log("Réponse reçue: %s", this.responseText);
                } else {
                    console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
                }
            }
        };