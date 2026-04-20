Algoritmo sin_titulo
	Definir opcion1, opcion2 Como Entero
    Definir valor, resultado Como Real
	
    Escribir "===== CONVERSOR DE LONGITUD ====="
    Escribir "Unidades:"
    Escribir "1. Metros"
    Escribir "2. Pies"
    Escribir "3. Centímetros"
    Escribir "4. Pulgadas"
	
    Escribir "Seleccione unidad de entrada:"
    Leer opcion1
	
    Escribir "Ingrese el valor a convertir:"
    Leer valor
	
    Escribir "Seleccione unidad de salida:"
    Leer opcion2
	
    // Convertir todo primero a metros
    Segun opcion1 Hacer
        1: // metros
            valor <- valor
        2: // pies
            valor <- valor * 0.3048
        3: // cm
            valor <- valor / 100
        4: // pulgadas
            valor <- valor * 0.0254
        De Otro Modo:
            Escribir "Unidad de entrada inválida"
    FinSegun
	
    // Convertir de metros a la unidad final
    Segun opcion2 Hacer
        1: // metros
            resultado <- valor
        2: // pies
            resultado <- valor / 0.3048
        3: // cm
            resultado <- valor * 100
        4: // pulgadas
            resultado <- valor / 0.0254
        De Otro Modo:
            Escribir "Unidad de salida inválida"
    FinSegun
	
    Escribir "Resultado: ", resultado
FinAlgoritmo
