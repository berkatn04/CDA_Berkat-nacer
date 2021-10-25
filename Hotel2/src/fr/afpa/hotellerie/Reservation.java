package fr.afpa.hotellerie;
import java.time.LocalDate;

public class Reservation {

	private LocalDate dateDebut;
	private LocalDate dateFin;
	private Chambre chambre;
	private static int nombreRes;
	private static int nombreLib;

	public Reservation(LocalDate dateDebutR, LocalDate dateFinR, Chambre chambreR) {

		dateDebut = dateDebutR;
		dateFin = dateFinR;
		chambre = chambreR;
		nombreRes++;
		chambre.reservationPlus();
		
	}
	
	public static int getNombreLib() {
		return nombreLib;
	}

	public static void setNombreLib(int nombreLibU) {
		nombreLib = nombreLibU;
	}
	
	public LocalDate getDateDebut() {
		return dateDebut;
	}

	public void setDateDebut(LocalDate dateDebutU) {
		dateDebut = dateDebutU;
	}

	public LocalDate getDateFin() {
		return dateFin;
	}

	public void setDateFin(LocalDate dateFinU) {
		dateFin = dateFinU;
	}

	public Chambre getChambre() {
		return chambre;
	}

	public void setChambre(Chambre chambreU) {
		chambre = chambreU;
	}

	public static int getNombreRes() {
		return nombreRes;
	}

	public static void setNombreRes(int nombreResU) {
		nombreRes = nombreResU;
	}
	
	public void reserveChambre(LocalDate date1 , LocalDate date2) {
		if (date1.isAfter(dateDebut) && date2.isBefore(dateFin) || date1.isBefore(dateDebut) && date2.isBefore(dateFin) && date2.isAfter(dateDebut) ||
				date1.isAfter(dateDebut) && date1.isBefore(dateFin) && date2.isAfter(dateFin) || date1.isBefore(dateDebut) && date2.isAfter(dateFin))   {
			chambre.setLibre(false);
		}else {
			chambre.setLibre(true);
		}
	}
}

