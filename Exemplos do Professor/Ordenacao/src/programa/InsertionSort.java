package programa;

import java.util.Arrays;

public class InsertionSort {

	public static void ordena(int[] vetor) {
		
		int j;
		int key;
		int i;
	
		for (j = 1; j < vetor.length; j++) {
			key = vetor[j];
		
			for (i = j - 1; (i >= 0) && (vetor[i] > key); i--) {
				vetor[i + 1] = vetor[i];
			}
			
			vetor[i + 1] = key;
			System.out.println(Arrays.toString(vetor));
		}
	}
}
