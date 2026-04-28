Algoritmo Lecc11_Act1_Inci1
	Definir cajones, capacidad, opcion Como Entero
	capacidad = 10
	cajones =0
	Repetir
		Escribir "------SISTEMA DE ACCESO------"
		Escribir "Cajones Ocupados: ",cajones, "/" ,capacidad
		Escribir "Cajones Disponibles: ",capacidad-cajones
		Escribir "Presione [1] para ingresar un auto, Presione [2] para sacar un auto y [0] para salir del sistema"
		Leer opcion
		
		si opcion=1 Entonces
			cajones=cajones+1
			Escribir "Ticket Impreso ¡Bienvenido!"
		SiNo
			si opcion = 2 Entonces
				cajones=cajones-1
				Escribir "¡Gracias, vuelva pronto!"
		SiNo
			si opcion <> 0 Entonces
				Escribir "Opcion no Válida"
				FinSi
			FinSi
		FinSi
		Escribir "------------------------------"
	Hasta Que cajones >= capacidad o opcion=0
	
	si cajones >= capacidad Entonces
		Escribir "AVISO: Estacionamiento lleno"
		Escribir "No se permite el ingreso de mas vehiculos"
	FinSi
FinAlgoritmo
