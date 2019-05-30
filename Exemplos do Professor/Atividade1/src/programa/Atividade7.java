package programa;

import java.util.Scanner;

public class Atividade7 {

	public static void main(String[] args) {
		 
		int linhas = 12;
		int colunas = 4;
				
		int matriz[][] = new int[linhas][colunas];
		
		Scanner sc = new Scanner(System.in);
		
		// Preenche matriz
		for (int i = 0; i < linhas; i++)
	    {
			for (int j = 0; j < colunas; j++) 
			{
				matriz[i][j] = sc.nextInt();
			}
	    }
		
		System.out.print("O total vendido por mes foi: ");
		System.out.print("\n");
		
		// a = Total vendido em cada mês do ano
		for (int i = 0; i < linhas; i++)
	    {
			int totalMes = 0;
			for (int j = 0; j < colunas; j++) 
			{
				totalMes = totalMes + matriz[i][j];
			}
			System.out.print("Total vendido no mes " + (i + 1) + ": " + totalMes);
			System.out.print("\n");
	    }
		
		System.out.print("\n");
		System.out.print("Total vendido em cada semana durante todo o ano: ");
		System.out.print("\n");
		
		int total = 0;
		
		// b = Total vendido em cada semana durante todo o ano; 
		for (int i = 0; i < linhas; i++)
	    {
			for (int j = 0; j < colunas; j++) 
			{
				System.out.print(matriz[i][j]);
				System.out.print("\t");
				total = total + matriz[i][j];
			}
			System.out.print("\n");
	    }
		
		System.out.print("\n");
		System.out.print("Total vendido no ano: ");
		System.out.print(total);
	}
}
