
public class TADFila {
	private Object item [ ] ;
	private int frente , tras ;
	
	public TADFila ( int maxTam) { 
		this .item = new Object[maxTam] ;
		this . frente = 0;
		this . tras = this . frente ;
		}
	
	public void enfileira (Object x) throws Exception {
		
		int a = this . tras + 1;
		int b = this .item.length;
		int c = this . frente;
		
		int d = a % b;
		
		if (( this . tras + 1) % this .item.length == this . frente)
		throw new Exception ( "Erro : A fila esta cheia" );
		this .item[this . tras ] = x;
		this . tras = (this . tras + 1) % this .item.length;
		}
}
