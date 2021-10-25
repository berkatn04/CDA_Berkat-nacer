package fr.afpa.hotellerie;


public class Chambre {

	private String type;
	private String superficie;
	private String vues;
	private String occupation;
	private int tarif;
	private int nombre;
	private String option;
	private int reservationMax;
	private boolean libre;
	private int numero;

	public Chambre(int numeroC, String typeC, String superficieC, String vuesC, String occupationC, int tarifC,
			String optionC) {
		libre =  true;
		numero = numeroC;
		reservationMax = 0;
		type = typeC;
		superficie = superficieC;
		vues = vuesC;
		occupation = occupationC;
		tarif = tarifC;
		option = optionC;
	}

	
	public boolean isLibre() {
		return libre;
	}
	
	public void setLibre(boolean libreU) {
		libre = libreU;
	}
	
	public int getNumero() {
		return numero;
	}
	
	public void setNumero(int numeroU) {
		numero = numeroU;
	}

	
	public int getReservationMax() {
		return reservationMax;
	}

	public void reservationPlus() {

		reservationMax++;
	}

	
	public String getType() {
		return type;
	}

	public String getSuperficie() {
		return superficie;
	}

	public String getVues() {
		return vues;
	}

	public String getOccupation() {
		return occupation;
	}

	public int getTarif() {
		return tarif;
	}

	public int getNombre() {
		return nombre;
	}

	public String getOption() {
		return option;
	}

	public String[] divisionOption() {
		String[] op = option.split("\\|");
		return op;
	}

	public void affichage() {
		System.out.println(type);
		System.out.println(superficie);
		System.out.println(vues);
		System.out.println(occupation);
		System.out.println(tarif);
		System.out.println(nombre);
		System.out.println(option);
		System.out.println("----------");
	}
}
