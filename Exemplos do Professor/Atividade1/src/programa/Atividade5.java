package programa;

import java.util.Scanner;

public class Atividade5 {
	
	public static void main(String[] args) {
		 
		int linhas = 5;
		int colunas = 5;
				
		int matriz[][] = new int[linhas][colunas];
		
		Scanner sc = new Scanner(System.in);
		
		for (int i = 0; i < linhas; i++)
	    {
			for (int j = 0; j < colunas; j++) 
			{
				matriz[i][j] = sc.nextInt();
			}
	    }
		
		for (int i = 0; i < linhas; i++)
	    {
			for (int j = 0; j < colunas; j++) 
			{
				System.out.print(matriz[i][j]);
				System.out.print("\t");
			}
			System.out.print("\n");
	    }
	}
}
