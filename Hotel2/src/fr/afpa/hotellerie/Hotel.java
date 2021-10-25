package fr.afpa.hotellerie;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

public class Hotel {
	public String[] type;
	private Chambre[] listChambre;
	private String mdp;
	private GestionClient gestionClient;
	private long CA;

	public Hotel(String[] typeH, GestionClient gestionClientH) {
		type = typeH;
		gestionClient = gestionClientH;
		listChambre = new Chambre[65];
		mdp = "ohyeah";
		CA = 0;
	}

	public Chambre[] splitChambre() {
		int numero = 1;

		for (int i = 1; i < type.length; i++) {
			
			String[] typeChambres = type[i].split(";");
			
			int nombreChambre = Integer.parseInt(typeChambres[5]);

			for (int j = 0; j < nombreChambre; j++) {
				Chambre chambre = new Chambre(numero, typeChambres[0], typeChambres[1], typeChambres[2], typeChambres[3],
						Integer.parseInt(typeChambres[4]), typeChambres[6]);
				listChambre[numero - 1] = chambre;
				numero++;
			}
			// listChambre.affichage();
			
		}
		return listChambre;
	}
	
	public Chambre[] getListChambre() {
		return listChambre;
	}
	
	public void setListChambre(Chambre[] listChambreU) {
		listChambre = listChambreU;
	}
	
	public String getMdp() {
		return mdp;
	}
	
	public boolean checkMdp(Scanner in, String mdp) {
		System.out.print("Entrez le mot de passe : ");
		String motDePasse = in.nextLine();
		System.out.println();
		boolean check = false;
		
		if (motDePasse.equals(mdp)) {
			check = true;
		}
		
		return check;
	}
	
	public void affichageLogin(Scanner in, Chambre[] chambre, GestionClient gestionClient, Hotel hotel) {

		int choix = 0;
		String login = "";
		boolean bonLogin = false;

		System.out.println();
		String log = "----------------------> Login <---------------------- \n";
		log = log + " 	(1) - LOGIN \n";
		log = log + " 	(2) - QUITTER \n";
		System.out.println(log);

		System.out.print("Entrez votre choix : ");

		while (true) {

			// quitter ou se logger
			choix = in.nextInt();
			in.nextLine();
			if (choix == 1) {

				System.out.print("Entrez un login : ");
				login = in.nextLine();

				if (login.equals("GH059")) {

					// entrer le login de l'employée
					affichageMenu(in, chambre, gestionClient, hotel);
					System.out.println(log);
					bonLogin = true;

				} else {

					// entrer un code client
					for (int i = 0; i < gestionClient.getListClient().length; i++) {

						if (gestionClient.getListClient()[i] != null
								&& gestionClient.getListClient()[i].getLogin() == Integer.parseInt(login)) {

							// afficher reservation;
							bonLogin = true;
							gestionClient.getListClient()[i].affichageReservation();
							System.out.println(log);
							System.out.print("Entrez votre choix : ");
							break;
						}
					}
				}
				if (bonLogin == false) {
					System.out.println("Login introuvable");
					System.out.println(log);
				}
			} else if (choix == 2) {

				// quitter l'application
				System.out.println("Au revoir !");
				break;

			} else {

				System.out.print("Veuillez choisir entre les deux options (1) ou (2): ");
			}

		}
	}
	
	public void affichageMenu(Scanner in, Chambre[] chambre, GestionClient gestionClient,
			Hotel hotel) {
		System.out.println();
		int choix = 0;
		String menu = "----------------------> MENU HOTEL CDA JAVA <---------------------- \n";
		menu = menu + "	(1) - Afficher l'état de l'hotel \n";
		menu = menu + "	(2) - Afficher le nombre de chambres réservées \n";
		menu = menu + "	(3) - Afficher le nombre de chambres libres \n";
		menu = menu + "	(4) - Afficher le numéro de la première chambre vide \n";
		menu = menu + "	(5) - Afficher le numéro de la dernière chambre vide \n";
		menu = menu + "	(6) - Réserver une chambre \n";
		menu = menu + "	(7) - Libérer une chambre \n";
		menu = menu + "	(8) - Modifier une réservation \n";
		menu = menu + "	(9) - Annuler une réservation \n";
		menu = menu + "	(10) - Afficher le CA à une date donnée\n";
		menu = menu + "	(11) - Quitter \n";
		System.out.println(menu);
	
		System.out.print("Entrez votre choix : ");
		choix = in.nextInt();
		in.nextLine();
		boolean password;
		while (choix != 11) {
			password = false;
			switch (choix) {
			case 1: // Afficher l'etat de l'hotel
	
				etatHotel();
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
			case 2: // Afficher le nombre de chambres reserves
	
				System.out.println();
				afficherChambreReserve();
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
			case 3: // Afficher le nombre de chambres libres
	
				System.out.println();
				afficherChambreLibre();
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
			case 4: // Afficher le numero de la premiere chambre
	
				premiereChambreVide(in);
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
			case 5: // Afficher le numero de la derniere chambre
	
				deniereChambreVide(in);
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
			case 6: // Reserver une chambre
				password = checkMdp(in, mdp);
				if (password == true) {
					reservation(in, chambre, gestionClient, hotel);
					System.out.print("Votre code client est : "
							+ gestionClient.getListClient()[gestionClient.getIndice() - 1].getLogin());
				}else {
					System.out.println("Le mot de passe est incorrect");
				}
				System.out.println();
				System.out.println();
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
			case 7: // Liberer une chambre
				password = checkMdp(in, mdp);
				if (password == true) {
					liberation(in, chambre, gestionClient);
				}else {
					System.out.println("Le mot de passe est incorrect");
				}
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
			case 8: // Modifier une reservation
				password = checkMdp(in, mdp);
				if (password == true) {
					modifier(in, gestionClient);
				}else {
					System.out.println("Le mot de passe est incorrect");
				}
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
			case 9: // Annuler une reservation
				password = checkMdp(in, mdp);
				if (password == true) {
					annulation(in, chambre, gestionClient);
				}else {
					System.out.println("Le mot de passe est incorrect");
				}
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
			case 10: // Afficher CA
				
				chiffreAffaire(in, gestionClient);
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
			case 11: // Quitter
	
				System.out.println(menu);
				System.out.print("Souhaitez-vous autre chose ? : ");
				choix = in.nextInt();
				in.nextLine();
				break;
	
			default:
				System.out.println("Veuillez faire un choix correct : ");
				break;
			}
		}
	}
	
	public void etatHotel() {
		System.out.println();
		System.out.println("Voici l'état de notre Hotel : ");
		System.out.println();
		afficherChambreReserve();
		for (int i = 0; i < gestionClient.getListClient().length; i++) {

			if (gestionClient.getListClient()[i] != null) {

				// Afficher client;
				System.out.println("Client Num. " + gestionClient.getListClient()[i].getLogin());
				// Afficher reservation
				System.out.print("	- Chambre Num " + gestionClient.getListClient()[i].getReservation().getChambre().getNumero() + " : " + gestionClient.getListClient()[i].getReservation().getChambre().getType() + " du " + gestionClient.getListClient()[i].getReservation().getDateDebut() + " au " + gestionClient.getListClient()[i].getReservation().getDateFin());
				if (LocalDate.now().isAfter(gestionClient.getListClient()[i].getReservation().getDateFin())) {
					System.out.println(" (Passé)");
				}
				System.out.println(); 
				System.out.println();
			}
		}
		
	}

	public void afficherChambreReserve() {
        if (Reservation.getNombreRes() == 0) {
            System.out.println("Il n'y a pas de chambre reservée. \n");
        }else if (Reservation.getNombreRes() == 1) {
            System.out.println("Il y a " + Reservation.getNombreRes() + " chambre reservé. \n");
        }else {
            System.out.println("Il y a " + Reservation.getNombreRes() + " chambres reservés. \n");
        }
    }
	
	public void afficherChambreLibre() {
        Reservation.setNombreLib(65 - Reservation.getNombreRes());
        if (Reservation.getNombreLib() == 0) {
            System.out.println("Il n'y a aucune chambre de libre \n");
        }else if (Reservation.getNombreLib() == 1) {
            System.out.println("Il y a " + Reservation.getNombreLib() + " chambre de libre. \n");
        }else {
            System.out.println("Il y a " + Reservation.getNombreLib() + " chambres de libre. \n");
        }
    }
	
	
	public void premiereChambreVide(Scanner in) {
		
		// Choix de la date
		System.out.print("Entrez la date de début (AAAA-MM-DD) : ");
		String d1 = in.nextLine();
		System.out.print("Entrez la date de fin (AAAA-MM-DD) : ");
		String d2 = in.nextLine();

		LocalDate date1 = LocalDate.parse(d1);
		LocalDate date2 = LocalDate.parse(d2);
		
		// Si l'utilisateur s'est trompé dans l'entré des dates
		while (date2.isBefore(date1)) {
			System.out.println("Entre une période valide");
			System.out.print("Entrez la date de début (AAAA-MM-DD) : ");
			d1 = in.nextLine();
			System.out.print("Entrez la date de fin (AAAA-MM-DD) : ");
			d2 = in.nextLine();

			date1 = LocalDate.parse(d1);
			date2 = LocalDate.parse(d2);
		}

		for (int i = 0; i < listChambre.length; i++) {
			if (gestionClient.getListClient()[i] != null) {
				gestionClient.getListClient()[i].getReservation().reserveChambre(date1, date2);
			}
			if (listChambre[i].isLibre() == true) {
				System.out.println();
				System.out.println("La premiere chambre libre est la chambre numéro " + listChambre[i].getNumero());
				System.out.println();
				break;
			}	
		}
	}

	public void deniereChambreVide(Scanner in) {
		
		// Choix de la date
		System.out.print("Entrez la date de début (AAAA-MM-DD) : ");
		String d1 = in.nextLine();
		System.out.print("Entrez la date de fin (AAAA-MM-DD) : ");
		String d2 = in.nextLine();
	
		LocalDate date1 = LocalDate.parse(d1);
		LocalDate date2 = LocalDate.parse(d2);
		
		// Si l'utilisateur s'est trompé dans l'entré des dates
		while (date2.isBefore(date1)) {
			System.out.println("Entre une période valide");
			System.out.print("Entrez la date de début (AAAA-MM-DD) : ");
			d1 = in.nextLine();
			System.out.print("Entrez la date de fin (AAAA-MM-DD) : ");
			d2 = in.nextLine();
	
			date1 = LocalDate.parse(d1);
			date2 = LocalDate.parse(d2);
		}
	
		for (int i = listChambre.length-1; i >= 0; i++) {
			if (gestionClient.getListClient()[i] != null) {
				gestionClient.getListClient()[i].getReservation().reserveChambre(date1, date2);
			}
			if (listChambre[i].isLibre() == true) {
				System.out.println();
				System.out.println("La derniere chambre libre est la chambre numéro " + listChambre[i].getNumero());
				System.out.println();
				break;
			}	
		}
	}
	
	
	public void reservation(Scanner in, Chambre[] chambre, GestionClient gestionClient, Hotel hotel) {
		int choix = 0;
	
		// Choix de la chambre
		String type = "Quelle type de chambre voulez vous ? : \n";
		type = type + "	(1) - Chambre Vue Piscine \n";
		type = type + "	(2) - Chambre Vue Jardin \n";
		type = type + "	(3) - Chambre Vue Ocean \n";
		type = type + "	(4) - Chambre vue imprenable sur l'océan \n";
		type = type + "	(5) - Suite CDA \n";
		type = type + "	(6) - Suite Executive \n";
		type = type + "	(7) - Suite Ambassadeur \n";
		type = type + "	(8) - Suite Royale \n";
		System.out.println(type);
		choix = in.nextInt();
		in.nextLine();
	
		// Choix de la date
		System.out.print("Entrez la date de début (AAAA-MM-DD) : ");
		String d1 = in.nextLine();
		System.out.print("Entrez la date de fin (AAAA-MM-DD) : ");
		String d2 = in.nextLine();
	
		LocalDate date1 = LocalDate.parse(d1);
		LocalDate date2 = LocalDate.parse(d2);
	
		// Si l'utilisateur s'est trompé dans l'entré des dates
		while (date2.isBefore(date1)) {
			System.out.println("Entre une période valide");
			System.out.print("Entrez la date de début (AAAA-MM-DD) : ");
			d1 = in.nextLine();
			System.out.print("Entrez la date de fin (AAAA-MM-DD) : ");
			d2 = in.nextLine();
	
			date1 = LocalDate.parse(d1);
			date2 = LocalDate.parse(d2);
		}
	
		Reservation reservation1;
	
		switch (choix) {
		case 1:
			for (int i = 0; i < 7; i++) {
				if (gestionClient.getListClient()[i] != null) {
					gestionClient.getListClient()[i].getReservation().reserveChambre(date1, date2);
				}
				if (chambre[i].getReservationMax() < 4 && chambre[i].isLibre() == true) {
					reservation1 = new Reservation(date1, date2, chambre[i]);
					Client client = new Client(reservation1);
					gestionClient.ajouterClient(client);
					client.affichageReservation();
					break;
				}
			}
			break;
		case 2:
	
			for (int i = 7; i < 19; i++) {
				if (gestionClient.getListClient()[i] != null) {
					gestionClient.getListClient()[i].getReservation().reserveChambre(date1, date2);
				}
				if (chambre[i].getReservationMax() < 4 && chambre[i].isLibre() == true) {
					reservation1 = new Reservation(date1, date2, chambre[i]);
					Client client = new Client(reservation1);
					gestionClient.ajouterClient(client);
					client.affichageReservation();
					break;
				}
			}
	
			break;
		case 3:
	
			for (int i = 19; i < 27; i++) {
				if (gestionClient.getListClient()[i] != null) {
					gestionClient.getListClient()[i].getReservation().reserveChambre(date1, date2);
				}
				if (chambre[i].getReservationMax() < 4 && chambre[i].isLibre() == true) {
					reservation1 = new Reservation(date1, date2, chambre[i]);
					Client client = new Client(reservation1);
					gestionClient.ajouterClient(client);
					client.affichageReservation();
					break;
				}
			}
	
			break;
		case 4:
	
			for (int i = 27; i < 37; i++) {
				if (gestionClient.getListClient()[i] != null) {
					gestionClient.getListClient()[i].getReservation().reserveChambre(date1, date2);
				}
				if (chambre[i].getReservationMax() < 4 && chambre[i].isLibre() == true) {
					reservation1 = new Reservation(date1, date2, chambre[i]);
					Client client = new Client(reservation1);
					gestionClient.ajouterClient(client);
					client.affichageReservation();
					break;
				}
			}
	
			break;
		case 5:
	
			for (int i = 37; i < 49; i++) {
				if (gestionClient.getListClient()[i] != null) {
					gestionClient.getListClient()[i].getReservation().reserveChambre(date1, date2);
				}
				if (chambre[i].getReservationMax() < 4 && chambre[i].isLibre() == true) {
					reservation1 = new Reservation(date1, date2, chambre[i]);
					Client client = new Client(reservation1);
					gestionClient.ajouterClient(client);
					client.affichageReservation();
					break;
				}
			}
	
			break;
		case 6:
	
			for (int i = 49; i < 54; i++) {
				if (gestionClient.getListClient()[i] != null) {
					gestionClient.getListClient()[i].getReservation().reserveChambre(date1, date2);
				}
				if (chambre[i].getReservationMax() < 4 && chambre[i].isLibre() == true) {
					reservation1 = new Reservation(date1, date2, chambre[i]);
					Client client = new Client(reservation1);
					gestionClient.ajouterClient(client);
					client.affichageReservation();
					break;
				}
			}
	
			break;
		case 7:
	
			for (int i = 54; i < 61; i++) {
				if (gestionClient.getListClient()[i] != null) {
					gestionClient.getListClient()[i].getReservation().reserveChambre(date1, date2);
				}
				if (chambre[i].getReservationMax() < 4 && chambre[i].isLibre() == true) {
					reservation1 = new Reservation(date1, date2, chambre[i]);
					Client client = new Client(reservation1);
					gestionClient.ajouterClient(client);
					client.affichageReservation();
					break;
				}
			}
	
			break;
		case 8:
	
			for (int i = 61; i < 65; i++) {
				if (gestionClient.getListClient()[i] != null) {
					gestionClient.getListClient()[i].getReservation().reserveChambre(date1, date2);
				}
				if (chambre[i].getReservationMax() < 4 && chambre[i].isLibre() == true) {
					reservation1 = new Reservation(date1, date2, chambre[i]);
					Client client = new Client(reservation1);
					gestionClient.ajouterClient(client);
					client.affichageReservation();
					break;
				}
			}
	
			break;
		default:
			System.out.println("Faites un bon choix la prochaine fois");
			System.out.println();
			break;
		}
	}

	public void liberation(Scanner in, Chambre[] chambre, GestionClient gestionClient) {
	
		int[] tabNumero = new int[65];
		int choix = 0;
		boolean bonChoix = false;
		System.out.println();
		System.out.println("Voici les chambres occupées : ");
		for (int i = 0; i < tabNumero.length; i++) {
			if (gestionClient.getListClient()[i] != null) {
				System.out.println("	- Chambre Num. : "
						+ gestionClient.getListClient()[i].getReservation().getChambre().getNumero());
				tabNumero[i] = gestionClient.getListClient()[i].getReservation().getChambre().getNumero();
			}
		}
		System.out.print("Quelle chambre voulez-vous liberer : ");
		choix = in.nextInt();
		in.nextLine();
		System.out.println();
		if (choix <= 65 && choix > 0) {
			for (int i = 0; i < tabNumero.length; i++) {
				if (choix == tabNumero[i]) {
					System.out.println("La chambre numéro "
							+ gestionClient.getListClient()[i].getReservation().getChambre().getNumero()
							+ " à bien été libérée");
					System.out.println();
					chambre[i].setLibre(true);
					gestionClient.getListClient()[i].setReservation(null);
					gestionClient.setListClient(i);
					bonChoix = true;
					break;
				}
			}
		}
		if (bonChoix == false && choix <= 65 && choix > 0) {
			System.out.println("Cette chambre n'est pas occupée");
		} else if (bonChoix == false && choix > 65 && choix <= 0) {
			System.out.println("Cette chambre n'existe pas");
		}
	
		System.out.println();
	}

	public void annulation(Scanner in, Chambre[] chambre, GestionClient gestionClient) {

		int login = 0;
		boolean bonLog = false;
		System.out.println();
		System.out.print("Entrez votre code client (login) : ");
		login = in.nextInt();
		LocalDate dateAujourd = LocalDate.now();

		for (int i = 0; i < gestionClient.getListClient().length; i++) {
			if (gestionClient.getListClient()[i] != null && gestionClient.getListClient()[i].getLogin() == login) {
				bonLog = true;
				if (dateAujourd.isBefore(gestionClient.getListClient()[i].getReservation().getDateDebut())) {
					chambre[i].setLibre(true);
					gestionClient.getListClient()[i].setReservation(null);
					gestionClient.setListClient(i);
					//gestionClient.getListClient()[i] = null;
					System.out.println();
					System.out.println("Cette réservation à bien été annulée");
					System.out.println();
					break;
				} else {
					System.out.println();
					System.out.println("Vous ne pouvez pas annuler cette réservation");
					System.out.println();
					break;
				}
			}
		}
		if (bonLog == false) {
			System.out.println("Login introuvable");
		}
	}
	
	public static void modifier(Scanner in, GestionClient gestionClient) {

		String login = "";
		boolean bonLog = false;

		System.out.print("Donnez le numero de client : ");
		login = in.nextLine();

		for (int i = 0; i < gestionClient.getListClient().length; i++) {

			if (gestionClient.getListClient()[i] != null
					&& gestionClient.getListClient()[i].getLogin() == Integer.parseInt(login)) {
				String nouvelleDebut = gestionClient.getListClient()[i].getReservation().getDateDebut().toString();
				String nouvelleFin = gestionClient.getListClient()[i].getReservation().getDateFin().toString();

				if (LocalDate.now().isBefore(LocalDate.parse(nouvelleDebut))) {

					String changementDate = "Quel date voulez vous changer ? : \n";
					changementDate = changementDate + "    (1) - Date du debut \n";
					changementDate = changementDate + "    (2) - Date de fin \n";
					System.out.println(changementDate);

					int choix = in.nextInt();
					in.nextLine();

					if (choix == 1) {
						System.out.print("Entrez la nouvelle date de debut (AAAA-MM-DD) : ");
						nouvelleDebut = in.nextLine();
						System.out.println(nouvelleDebut);
					} else if (choix == 2) {
						System.out.print("Entrez la nouvelle date de fin (AAAA-MM-DD) : ");
						nouvelleFin = in.nextLine();
					}
					LocalDate dateDebut = LocalDate.parse(nouvelleDebut);
					gestionClient.getListClient()[i].getReservation().setDateDebut(dateDebut);
					LocalDate dateFin = LocalDate.parse(nouvelleFin);
					gestionClient.getListClient()[i].getReservation().setDateFin(dateFin);
					bonLog = true;
					break;
				}else {
					System.out.println("La date de réservation est déjà passée");
					bonLog = true;
				}
			}
		}
		if (bonLog == false) {
			System.out.println("Login introuvable");
		}
	}
	
	public static void chiffreAffaire(Scanner in, GestionClient gestionClient) {
		
		long CA = 0;
		
		System.out.print("A quelle date voulez-vous le chiffre d'affaire (AAAA-MM-JJ) : ");
		String dateChiffreTemp = in.nextLine();
		
		System.out.println();
		
		LocalDate dateChiffre = LocalDate.parse(dateChiffreTemp);
		
		for(int i = 0 ; i < gestionClient.getListClient().length ; i++) {
			
			if (gestionClient.getListClient()[i] != null) {
				
				if (dateChiffre.isBefore(LocalDate.now()) && dateChiffre.isAfter(gestionClient.getListClient()[i].getReservation().getDateDebut())) {
					
					if (dateChiffre.isBefore(gestionClient.getListClient()[i].getReservation().getDateFin())) {
						CA = CA + (ChronoUnit.DAYS.between(gestionClient.getListClient()[i].getReservation().getDateDebut(), dateChiffre) 
								* gestionClient.getListClient()[i].getReservation().getChambre().getTarif());
						
					} else if (dateChiffre.isAfter(gestionClient.getListClient()[i].getReservation().getDateDebut())) {
						CA = CA + (ChronoUnit.DAYS.between(gestionClient.getListClient()[i].getReservation().getDateDebut()
								, gestionClient.getListClient()[i].getReservation().getDateFin()) 
								* gestionClient.getListClient()[i].getReservation().getChambre().getTarif());
					}

				}

			}
			
		}
		
		System.out.println("L'hotel a fait rentré à ce jour " + CA + "€. Un beau paquet de pognons.");
		
	}
}
