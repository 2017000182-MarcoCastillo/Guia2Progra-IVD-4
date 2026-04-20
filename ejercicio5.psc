Algoritmo sin_titulo
	Definir numero Como Entero
    Definir mes Como Cadena
    Definir dias Como Entero
	
    Escribir "Ingrese un número del 1 al 12:"
    Leer numero
	
    Segun numero Hacer
        1:
            mes <- "Enero"
            dias <- 31
        2:
            mes <- "Febrero"
            dias <- 28
        3:
            mes <- "Marzo"
            dias <- 31
        4:
            mes <- "Abril"
            dias <- 30
        5:
            mes <- "Mayo"
            dias <- 31
        6:
            mes <- "Junio"
            dias <- 30
        7:
            mes <- "Julio"
            dias <- 31
        8:
            mes <- "Agosto"
            dias <- 31
        9:
            mes <- "Septiembre"
            dias <- 30
        10:
            mes <- "Octubre"
            dias <- 31
        11:
            mes <- "Noviembre"
            dias <- 30
        12:
            mes <- "Diciembre"
            dias <- 31
        De Otro Modo:
            Escribir "Número inválido"
    FinSegun
	
    Escribir "Mes: ", mes
    Escribir "Días: ", dias
FinAlgoritmo
