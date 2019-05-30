package programa;

public class Programa {
	public static void main(String[] args) {
	    
	    int quantidade = 10;	    
	    int[] vetor = { 100, 15, 65, 65, 76, 3, 4, 6, 8, 89 };
	    
	    // InsertionSort
	    InsertionSort insertionSort = new InsertionSort();
	    insertionSort.ordena(vetor);
	    
	    // SelectionSort
	    // SelectionSort selectionSort = new SelectionSort();
	    // selectionSort.ordena(vetor);
	    
	    // ShellSort
	    // ShellSort shellSort = new ShellSort();
	    // shellSort.ordena(vetor);
	    
	    // QuickSort
	    // QuickSort quickSort = new QuickSort();
	    // quickSort.ordena(vetor, 0 , quantidade - 1);
	}
}
