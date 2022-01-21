<div class="demiPage colonne">
    <form action="index.php?page=actionInscription" method="POST">
       
            <label for="nom">Nom</label>
            <input type="text" name="nom" required />
        
            <label for="prenom">Prenom</label>
            <input type="text" name="prenom" required />
        
            <label for="motDePasse">mot De Passe</label>
            <input type="password" name="motDePasse" required />
       
            <label for="confirmation">Confirmation du mot de passe</label>
            <input type="password" name="confirmation" required />
        
            <label for="adresseMail">Adresse mail</label>
            <input type="text" name="adresseMail" required />
        
            <label for="role">Role (1 : user - 2 : admin)</label>
            <input type="text" name="role" required />
        
            <label for="pseudo">Pseudo</label>
            <input type="text" name="pseudo" required />
        
            <div></div>
            <div></div>
            <div></div>
            <button type="submit">Valider</button>
            
        
    </form>