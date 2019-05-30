
public class Programa {

	public static void main(String[] args) {
		Lista lista = new Lista();
		
		lista.insere(1);
		lista.insere(2);
		lista.insere(3);
		lista.insere(4);
		lista.insere(5);
		lista.insere(6);
		lista.insere(7);
		lista.insere(8);
		lista.insere(9);
		lista.insere(10);
		
		lista.imprime();
		System.out.println("\n");
		
		lista.troca(2, 4);
		lista.imprime();
		System.out.println("\n");
		
		lista.troca(1, 10);
		lista.imprime();
		System.out.println("\n");
		
		lista.troca(3, 9);
		lista.imprime();
		System.out.println("\n");
		
	}

}
