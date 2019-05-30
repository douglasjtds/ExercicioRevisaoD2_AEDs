package programa;

import java.util.Scanner;

public class Atividade4 {

	public static void main(String[] args) {
		 
		double vetor[] = new double[10];
		
		Scanner sc = new Scanner(System.in);
		
		for (int i = 0; i < vetor.length; i++)
	    {
			vetor[i] = sc.nextDouble() / 2;
	    }
		
		for (int i = 0; i < vetor.length; i++)
	    {
			System.out.println(vetor[i]);
	    }
	}
}
