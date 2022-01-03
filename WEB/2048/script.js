var grille = document.querySelector('.grille');
var scoretot = document.getElementById('score');
var resultat = document.getElementById('resultat')
var tableau = []
score = 0




function initTab(){
    for(i=0; i < 16 ; i++){
        tab = document.createElement('div')
        tab.innerHTML= 0
        grille.appendChild(tab)
        tableau.push(tab)
    }
    ajoutNombres();
    ajoutNombres();
    
}

window.addEventListener("load",initTab());


function ajoutNombres(){
    var pos1 = Math.floor(Math.random()*16)
    if(tableau[pos1].innerHTML==0){
        tableau[pos1].innerHTML=2
       
    }
    else ajoutNombres();
}


function somme(){
    for(i=0;i<16;i++){
        if(tableau[i].innerHTML == tableau[i+1].innerHTML){
            var som = tableau[i].innerHTML + tableau[i+1].innerHTML
            tableau[i+1].innerHTML = som 
            tableau[i] = 0
            score += som
            scoretot.innerHTML = score
        }
    }
}

function deplacement(e){
    if(e.keyCode == 39){
        deplacementDroite();
        
    }
}


function deplacementDroite(){
        
      
    
    }



function Victoire(){
    for (let i=0; i < tableau.length; i++) {
        if (tableau[i].innerHTML == 2048) {
          resultat.innerHTML = 'Victoire'
        }
    }
}

function Defaite(){
    resultat.innerHTML = 'Victoire'
}