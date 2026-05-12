Algoritmo Lecc9_Act2_Inci1	
    Definir monedas Como Entero
	
    Repetir
        
        Escribir "Ingrese la cantidad de monedas del jugador: "
        Leer monedas
		
        Si monedas < 350 Entonces
            Escribir "Nivel 5 bloqueado. Necesitas al menos 350 monedas."
        FinSi
		
    Hasta Que monedas >= 350
	
    Escribir "¡Felicidades! Has desbloqueado el Nivel 5."
	
FinAlgoritmo
