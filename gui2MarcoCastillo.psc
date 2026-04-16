Algoritmo Ejercicio2
	Definir num1, num2, opc, result Como Real
	Definir msj Como Caracter
	Escribir Sin Saltar "Digite dos valores numericos: "
	Leer num1
	Leer num2
	
	//menu de operaciones
	Escribir "***********"
	Escribir "Menu principal"
	Escribir "***********"
	Escribir "1- suma"
	Escribir "2- Resta"
	Escribir "3- Multiplicacion"
	Escribir "4- Division"
	Escribir "5- Saltar"
	Escribir Sin Saltar "digite el numero segun su operacion: "
	Leer opc
	
	//evaluar Opcion 
	
	Segun opc Hacer
		1:
			msj="El resultado de suma es:"
			result=num1+num2
		2:
			msj="El resultado de resta es:"
			result=num1-num2
		3:
			msj="El resultado de Multiplicacion es:"
			result=num1*num2
		4:
			msj="El resultado de Division es:"
			result=num1/num2
		5:
			msj="Saliendo del sistema..."
		De Otro Modo:
			msj="Seleccione opcion valida!!!"
	Fin Segun
	
	Escribir msj
	Escribir result
FinAlgoritmo
