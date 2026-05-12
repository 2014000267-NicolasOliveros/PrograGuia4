Algoritmo Lecc9_Act
	Definir man, peso, pesotot, mantot Como Entero
	
	Repetir
		
	Escribir "Digita el peso de una manzana mayor a 180g: "
	Leer peso
	Si peso >= 180 Entonces
		pesotot = pesotot + peso
	SiNo
		Escribir "El numero es menor a 180 o es invalido"
	Fin Si
	Escribir "El peso total es de: ",pesotot
	
	mantot = mantot+1
	
	Escribir "Llevas ",mantot," Manzanas"
	
Hasta Que  pesotot >= 1000

Si pesotot = 1000  Entonces
	Escribir "Se ha completado el Kilo de manzana exacto"
SiNo
	Escribir "Se ha excedido el peso de un kilo"
Fin Si
FinAlgoritmo
