Algoritmo Lecc11_Act3_Inci1
	
    Definir num1, num2, menor, mayor, i, suma Como Entero
	
    Escribir "Ingrese el primer numero: "
    Leer num1
	
    Escribir "Ingrese el segundo numero: "
    Leer num2
	
    Si num1 < num2 Entonces
        menor <- num1
        mayor <- num2
    SiNo
        menor <- num2
        mayor <- num1
    FinSi
	
    suma <- 0
	
    Para i <- menor Hasta mayor Hacer
        
        suma <- suma + i
		
    FinPara
	
    Escribir "La suma es: ", suma
	
FinAlgoritmo