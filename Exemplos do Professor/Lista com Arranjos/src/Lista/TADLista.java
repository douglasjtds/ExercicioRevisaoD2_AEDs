package Lista;

public class TADLista implements Lista {

	private Object item[];
	private int primeiro, ultimo, pos;
	
	public TADLista(int maxTam) {
		this.item = new Object[maxTam]; 
		this.pos = -1;
		this.primeiro = 0;
		this.ultimo = this.primeiro;
	}
	
	@Override
	public Object pesquisa(Object chave) {
		if (this.vazia() || chave == null) 
			return null;
		for (int p = 0; p < this . ultimo ; p++)
			if (this.item[p].equals(chave)) 
				return this.item[p];
		return null ;
	}

	@Override
	public void insere(Object x) {
		if (this.ultimo >= this.item.length)
			System.out.println( "Erro : A lista esta cheia" );
		else { 
			this.item[this.ultimo] = x;
			this.ultimo = this.ultimo + 1; 
		}
	}

	@Override
	public Object retira(Object chave) {
		if (this.vazia() || chave == null)
			System.out.println( "Erro : A lista esta vazia" );
		int p = 0;
		while(p < this.ultimo && !this.item[p].equals(chave))
			p++;
		if (p >= this.ultimo) 
			return null; // Chave não encontrada
		Object item = this.item[p];
		this.ultimo = this.ultimo - 1;
		for (int aux = p; aux < this.ultimo; aux++)
			this .item[aux] = this .item[aux + 1];
		return item;
	}

	@Override
	public Object retiraPrimeiro() {
		if (this.vazia())
			System.out.println( "Erro : A lista esta vazia" );
		Object item = this.item[0];
		this.ultimo = this.ultimo - 1;
		for (int aux = 0; aux < this.ultimo ; aux++)
			this.item[aux] = this.item[aux + 1];
		return item;
	}

	@Override
	public Object primeiro() {
		this.pos = -1; 
		return this.proximo();
	}

	public Object proximo() {
		this.pos++;
		if (this.pos >= this.ultimo) 
			return null;
		else 
			return this.item[this.pos];
	}
	
	@Override
	public boolean vazia() {
		return (this.primeiro == this.ultimo);
	}

	public void imprime() {
		for (int aux = this.primeiro; aux < this.ultimo; aux++)
			System.out.println (this.item[aux].toString());
	}
	
	@Override
	public Object retiraUltimo() {
		if (this.vazia())
			System.out.println( "Erro : A lista esta vazia" );
		this.item[this.ultimo - 1] = null;
		this.ultimo = this.ultimo - 1;
		return this.item;
	}

	@Override
	public Object ultimo() {
		return this.item[this.ultimo - 1];
	}

	@Override
	public int tamanhoLista() {
		return this.ultimo;
	}

	@Override
	public void insere(Object x, Object chave) {
		Object aux = null;
		if (this.ultimo >= this.item.length)
			System.out.println( "Erro : A lista esta cheia" );
		else { 
			for (int chaveAux = this.ultimo; chaveAux > (int)chave; chaveAux--) {
				this.item[chaveAux] = this.item[chaveAux - 1];
			}
			this.item[(int)chave] = x;
			this.ultimo = this.ultimo + 1; 
		}
		
	}

	@Override
	public Object[] concatenar(Object[] a, Object[] b) {
		
		Object item[];
		
		item = new Object[a.length + b.length];
		int count = 0;
		
		for (int i = 0; i < a.length; i++) {
			item[count] = a[i];
			count++;
		}
		for (int i = 0; i < b.length; i++) {
			item[count] = b[i];
			count++;
		}
		return item;
	}

	@Override
	public Object[] copia() {
		
		Object item[];
		item = new Object[this.item.length];
		
		for (int i = 0; i < this.item.length; i++) {
			item[i] = this.item[i];
		}
		return item;
	}
}
