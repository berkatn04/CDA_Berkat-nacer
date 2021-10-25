package fr.afpa.hotellerie;

public class GestionClient {
	private Client[] listClient;
	private int indice;
	
	public GestionClient() {
		listClient = new Client[65];
	}
	
	public Client[] getListClient() {
		return listClient;
	}
	
	public void setListClient(int indice) {
		listClient[indice] = null;
	}
	
	public void ajouterClient(Client client) {
		listClient[indice] = client;
		indice++;
	}
	
	public int getIndice() {
		return indice;
	}
	
	public void setIndice(int indiceU) {
		indice = indiceU;
	}
}
