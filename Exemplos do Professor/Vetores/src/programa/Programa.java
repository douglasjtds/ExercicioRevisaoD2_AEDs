package programa;

public class Programa {

	// Defina tamanho de colunas e linhas
	public static int linhas = 5;
	public static int colunas = 3;
    
    // Declaro Vetor e Matriz
    public static int vetor[] = new int[colunas];
    public static int matriz[][] = new int[linhas][colunas];
	
	public static void main(String[] args) {
		
		construirVetor();
		
		construirMatriz();
		
		imprimeVetor();
		
		imprimeMatriz();;
	}
	
	// Metodo para Preencher Vetor
	public static void construirVetor() {
		
		// Valor que será incrementado no Vetor
	    int valor = 1;
		
		// Construir Vetor
	    for (int i = 0; i < colunas; i++)
	    {
	    	vetor[i] = valor;
	        valor++;
	    }
	}
	
	// Metodo para Preencher Matriz
	public static void construirMatriz() {
		
		// Valor que será incrementado na Matriz
		int valor = 1;
	    
	    // Construir Matriz
	    for (int i = 0; i < linhas; i++)
	    {
	        for (int j = 0; j < colunas; j++)
	        {
	        	matriz[i][j] = valor;
	            valor++;
	        }
	    }
	}
	
	public static void imprimeVetor() {
		
		System.out.print("Imprimindo vetor: ...");
		System.out.print("\n");
		
		// Imprimir Vetor
	    for (int i = 0; i < colunas; i++)
	    {
	    	System.out.print(vetor[i]);
	    	System.out.print("\t");
	    }
	    
	    System.out.print("\n");
	}
	
	public static void imprimeMatriz() {
		
		System.out.print("Imprimindo matriz: ...");
		System.out.print("\n");
		
		// Imprimir Matriz
	    for (int i = 0; i < linhas; i++)
	    {
	        for (int j = 0; j < colunas; j++)
	        {
	        	System.out.print(matriz[i][j]);
	        	System.out.print("\t");
	        }
	        System.out.print("\n");
	    }
	    
	    System.out.print("\n");
	}
}
