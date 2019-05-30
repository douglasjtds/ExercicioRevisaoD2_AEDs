package Lista;
import java.util.ArrayList;

public interface Lista {

	Object pesquisa(Object chave);
	void insere(Object x);
	Object retira(Object chave);
	Object retiraPrimeiro();
	Object primeiro();
	boolean vazia();
	
	Object retiraUltimo();
	Object ultimo();
	int tamanhoLista();
	void insere(Object x, Object chave);
	Object[] concatenar(Object[] a, Object[] b);
	Object[] copia();
	
}