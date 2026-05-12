Algoritmo Lecc9_Act3_Inci2
	
    Definir num, i, contador Como Entero
	
    Escribir "Ingrese un numero entero: "
    Leer num
	
    contador <- 0
    i <- 1
	
    Repetir
        
        Si num % i = 0 Entonces
            contador <- contador + 1
        FinSi
		
        i <- i + 1
		
    Hasta Que i > num
	
    Si contador = 2 Entonces
        Escribir "El numero es primo"
    SiNo
        Escribir "El numero no es primo"
    FinSi
	
FinAlgoritmo