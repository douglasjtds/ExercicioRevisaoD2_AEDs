package Programa;

import Contato.*;
import Lista.*;

public class Programa {

	public static void main(String[] args) {
		Lista lista = new TADLista(100);
		
		Contato contato1 = new Contato();
		Contato contato2 = new Contato();
		Contato contato3 = new Contato();
		
		contato1.setNome("Jose");
		contato2.setNome("Maria");
		contato3.setNome("Joao");
		
		lista.insere(contato1);
		lista.insere(contato2);
		lista.insere(contato3);
		
		Contato item = (Contato)lista.pesquisa(contato2);
		String nomeItem = item.getNome();
		System.out.println(nomeItem);
		
		lista.retira(contato2);
		lista.retiraPrimeiro();
		Contato primeiro = (Contato)lista.primeiro();
		
		String nomePrimeiro = primeiro.getNome();
		System.out.println(nomePrimeiro);
		
		// ------------------------------------------
		
		Contato contato4 = new Contato();
		Contato contato5 = new Contato();
		Contato contato6 = new Contato();
		
		contato4.setNome("Tadeu");
		contato5.setNome("Julia");
		contato6.setNome("Mateus");
		
		lista.insere(contato4);
		lista.insere(contato5);
		lista.insere(contato6, 1);
		
		Contato ultimo = (Contato)lista.ultimo();
		String nomeUltimo = ultimo.getNome();
		System.out.println(nomeUltimo);
		
		lista.retiraUltimo();
		
		System.out.println("O tamanho da lista eh: " + lista.tamanhoLista());
	}
}
