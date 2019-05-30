package programa;

public class Atividade2 {

	public static void main(String[] args) {
			 
		int vetor[] = new int[100];
		int iCont = 0;
		
		for (int i = 0; i <= vetor.length; i++)
	    {
			if(i%2==0 && i > 0){
				vetor[iCont] = i;
				iCont++;
			}
	    }
		
		for (int i = 0; i < vetor.length / 2; i++)
	    {
			System.out.println(vetor[i]);
	    }
	}
}
