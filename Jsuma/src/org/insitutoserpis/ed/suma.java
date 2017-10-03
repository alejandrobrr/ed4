package org.insitutoserpis.ed;

import java.math.BigDecimal;

public class suma {
	 	
	public static void main (String [] args) {
		String primerNumero = "14"; 
		BigDecimal primero = new BigDecimal(primerNumero);
		String segundoNumero = "33";
		BigDecimal segundo = new BigDecimal(segundoNumero);
		BigDecimal suma = primero.add(segundo);
		System.out.println("La suma es"+ suma);
	}


}
