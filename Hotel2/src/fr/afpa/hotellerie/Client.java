package fr.afpa.hotellerie;

public class Client {
	private int login;
	private static int nouveauLog;
	private Reservation reservation;

	public Client(Reservation reservationC) {
		nouveauLog++;
		login = 1000000000 + nouveauLog;
		reservation = reservationC;
	}

	public void setLogin(int loginU) {
		login = loginU;
	}

	public int getLogin() {
		return login;
	}

	public static void setNouveauLog(int nouveauLogU) {
		nouveauLog = nouveauLogU;
	}

	public static int getNouveauLog() {
		return nouveauLog;
	}
	
	public Reservation getReservation() {
		return reservation;
	}
	
	public void setReservation(Reservation reservationU) {
		reservation = reservationU;
	}

	public void affichageReservation() {
		System.out.println();
		System.out.println("----------> Détails de votre reservation <-----------");
		System.out.println("	-> Numéro de chambre : " + reservation.getChambre().getNumero());
		System.out.println("	-> Du : " + reservation.getDateDebut() + " au " + reservation.getDateFin());
		System.out.println("	-> Type de chambre : " + reservation.getChambre().getType());
		System.out.println("	-> Prix : " + reservation.getChambre().getTarif() + "€");
		System.out.println("	-> Options : " + reservation.getChambre().getOption());
		System.out.println();
	}

}
