package programa;

import java.util.Scanner;

public class Atividade6 {

	public static void main(String[] args) {
		 
		int linhas = 4;
		int colunas = 4;
				
		int matrizA[][] = new int[linhas][colunas];
		int matrizB[][] = new int[linhas][colunas];
		int matrizSOMA[][] = new int[linhas][colunas];
		
		Scanner sc = new Scanner(System.in);
		
		// Preenche matriz A
		for (int i = 0; i < linhas; i++)
	    {
			for (int j = 0; j < colunas; j++) 
			{
				matrizA[i][j] = sc.nextInt();
			}
	    }
		
		// Preenche matriz B
		for (int i = 0; i < linhas; i++)
	    {
			for (int j = 0; j < colunas; j++) 
			{
				matrizB[i][j] = sc.nextInt();
			}
	    }

		// Preenche matriz SOMA
		for (int i = 0; i < linhas; i++)
	    {
			for (int j = 0; j < colunas; j++) 
			{
				matrizSOMA[i][j] = matrizA[i][j] + matrizB[i][j];
			}
	    }
		
		// Imprime matriz SOMA
		for (int i = 0; i < linhas; i++)
	    {
			for (int j = 0; j < colunas; j++) 
			{
				System.out.print(matrizSOMA[i][j]);
				System.out.print("\t");
			}
			System.out.print("\n");
	    }
	}
}
