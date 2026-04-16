Algoritmo Ejercicio4
	Definir opc Como Real
	Escribir Sin Saltar "Digite dos valores numericos: "
	Leer num1
	Leer num2
	
	//menu pricipal
	Escribir "***********"
	Escribir "Menu principal"
	Escribir "***********"
	Escribir "1- HAMBURGUESAS"
	Escribir "2- PIZZA"
	Escribir "3- POLLO FRITO"
	Escribir "4- EMSALADA"
	Escribir "5- Saltar"
	Escribir Sin Saltar "digite UN MENU: "
	Leer opc
	
	//evaluar Opcion 
	
	Segun opc Hacer
		1:
			Escribir "Usted a solicitado -->"
			Escribir "un platillo de hamburguesas"
		2:
			Escribir "Usted a solicitado -->"
			Escribir "un platillo de pizza"
		3:
			Escribir "Usted a solicitado -->"
			Escribir "un platillo de pollo frito"
		4:
			Escribir "Usted a solicitado -->"
			Escribir "un platillo de ensalada"
		5:
			Escribir "Saliendo del sistema..."
		De Otro Modo:
			Escribir "Seleccione un menu!!"
	Fin Segun
	
	Escribir msj
	Escribir result
FinAlgoritmo
