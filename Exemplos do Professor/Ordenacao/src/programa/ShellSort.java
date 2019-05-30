package programa;

import java.util.Arrays;

public class ShellSort {

	public static void ordena ( int [ ] vetor ) {  
		int i , j , h = 1, value;
		
		do {
			h = 3 * h + 1;
		} while ( h < vetor.length );
		
		do {
			h = h / 3;
			
			for ( i = h; i < vetor.length; i++) {
				value = vetor [ i ];
				j = i - h;
				
				while (j >= 0 && value < vetor [ j ]) {
					vetor [ j + h ] = vetor [ j ];
					j = j - h;
				}
				
				vetor [ j + h ] = value;
				
				System.out.println(Arrays.toString(vetor));
			}
		} while ( h > 1 );
	}
}
