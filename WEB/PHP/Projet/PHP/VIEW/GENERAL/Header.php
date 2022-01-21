<body class="colonne">
    <header>
        <div class="demi"></div>
        <div><img src="" alt=""></div>
        <div>
            <?php

            if (isset($_SESSION['utilisateur'])) {
                echo '<div><a href="index.php?page=ActionDeconnexion" class="center">'. texte("Deconnexion") .'</a></div>';
                echo '<div class="center">'. texte('Bonjour') ." ". $_SESSION['utilisateur']->getPrenom() . '</div>';
                
            } else {
                echo '<a href="index.php?page=Default" class="center">'. texte("Connexion") .'</a>';
            }
            ?>

        </div>

    </header>