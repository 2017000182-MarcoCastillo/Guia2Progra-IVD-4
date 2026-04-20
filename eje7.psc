Algoritmo sin_titulo
	Definir caracter Como Cadena
    Definir c Como Cadena
	
    Escribir "Ingrese un carácter:"
    Leer caracter
	
    Si Longitud(caracter) <> 1 Entonces
        Escribir "Debe ingresar solo un carácter"
    Sino
        // Convertir a minúscula para simplificar
        c <- Minusculas(caracter)
		
        Si c = "a" O c = "e" O c = "i" O c = "o" O c = "u" Entonces
            Escribir "Es una vocal"
        Sino
            // Verificar si es dígito
            Si caracter >= "0" Y caracter <= "9" Entonces
                Escribir "Es un dígito"
            Sino
                Escribir "No es vocal ni dígito"
            FinSi
        FinSi
    FinSi
FinAlgoritmo
