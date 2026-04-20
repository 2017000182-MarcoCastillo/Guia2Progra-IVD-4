Algoritmo sin_titulo
	Definir sector, opcion, cantidad Como Entero
    Definir precio, total Como Real
	
    Escribir "===== VENTA DE ENTRADAS ====="
    Escribir "1. Palco (Q300)"
    Escribir "2. Tribuna (Q100 - Q125)"
    Escribir "3. Preferencia (Q50 - Q75)"
    Escribir "4. Generales (Q30 - Q50)"
    Escribir "Seleccione un sector:"
    Leer sector
	
    Segun sector Hacer
        1:
            precio <- 300
			
        2:
            Escribir "Tribuna:"
            Escribir "1. Q100"
            Escribir "2. Q125"
            Leer opcion
			
            Si opcion = 1 Entonces
                precio <- 100
            Sino
                Si opcion = 2 Entonces
                    precio <- 125
                Sino
                    Escribir "Opción inválida"
                FinSi
            FinSi
			
        3:
            Escribir "Preferencia:"
            Escribir "1. Q50"
            Escribir "2. Q75"
            Leer opcion
			
            Si opcion = 1 Entonces
                precio <- 50
            Sino
                Si opcion = 2 Entonces
                    precio <- 75
                Sino
                    Escribir "Opción inválida"
                FinSi
            FinSi
			
        4:
            Escribir "Generales:"
            Escribir "1. Q30"
            Escribir "2. Q50"
            Leer opcion
			
            Si opcion = 1 Entonces
                precio <- 30
            Sino
                Si opcion = 2 Entonces
                    precio <- 50
                Sino
                    Escribir "Opción inválida"
                FinSi
            FinSi
			
        De Otro Modo:
            Escribir "Sector inválido"
    FinSegun
	
    Escribir "Ingrese cantidad de entradas:"
    Leer cantidad
	
    Si cantidad > 0 Entonces
        total <- precio * cantidad
        Escribir "Total a pagar: Q", total
    Sino
        Escribir "Cantidad inválida"
    FinSi
FinAlgoritmo
