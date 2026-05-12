Algoritmo Lecc10_Act3_Inci1
	
    Definir num, i, divisor, contador, suma Como Entero
	
    suma <- 0
	
    Para num <- 1 Hasta 22 Hacer
        
        contador <- 0
		
        Para divisor <- 1 Hasta num Hacer
            
            Si num % divisor = 0 Entonces
                contador <- contador + 1
            FinSi
			
        FinPara
		
        Si contador = 2 Entonces
            suma <- suma + num
        FinSi
		
    FinPara
	
    Escribir "La suma de los numeros primos entre 1 y 22 es: ", suma
	
FinAlgoritmo