package programa;

import java.util.Arrays;

public class QuickSort {
	
	public static void ordena(int[] vetor, int inicio, int fim) {
		
		if (inicio < fim) {
			int posicaoPivo = separar(vetor, inicio, fim);
			ordena(vetor, inicio, posicaoPivo - 1);
			ordena(vetor, posicaoPivo + 1, fim);
		}
	}

	private static int separar(int[] vetor, int inicio, int fim) {
		
		int pivo = vetor[inicio];
		int i = inicio + 1, f = fim;
		
		while (i <= f) {
			if (vetor[i] <= pivo)
				i++;
			else if (pivo < vetor[f])
				f--;
			else {
				int troca = vetor[i];
				vetor[i] = vetor[f];
				vetor[f] = troca;
				i++;
				f--;
			}
		}
		
		vetor[inicio] = vetor[f];
		vetor[f] = pivo;
		
		System.out.println(Arrays.toString(vetor));
		return f;
	}
}
