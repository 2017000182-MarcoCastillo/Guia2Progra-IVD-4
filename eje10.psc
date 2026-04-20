Algoritmo sin_titulo
	Definir cantidad, opcion Como Entero
    Definir precioSinIVA, precioConIVA, totalSinDesc, descuento, totalPagar Como Real
    Definir formaPago Como Cadena
	
    precioSinIVA <- 650
    precioConIVA <- precioSinIVA * 1.12
	
    Escribir "Ingrese cantidad de impresoras:"
    Leer cantidad
	
    Escribir "Forma de pago:"
    Escribir "1. Efectivo (10%)"
    Escribir "2. Tarjeta de crédito (5%)"
    Escribir "3. Vale de regalo (15%)"
    Leer opcion
	
    totalSinDesc <- precioConIVA * cantidad
	
    Segun opcion Hacer
        1:
            formaPago <- "Efectivo"
            descuento <- totalSinDesc * 0.10
			
        2:
            formaPago <- "Tarjeta de crédito"
            descuento <- totalSinDesc * 0.05
			
        3:
            formaPago <- "Vale de regalo"
            descuento <- totalSinDesc * 0.15
			
        De Otro Modo:
            Escribir "Opción inválida"
            descuento <- 0
            formaPago <- "Ninguna"
    FinSegun
	
    totalPagar <- totalSinDesc - descuento
	
    Escribir "===== DETALLE DE COMPRA ====="
    Escribir "Cantidad: ", cantidad
    Escribir "Precio con IVA: Q", precioConIVA
    Escribir "Total sin descuento: Q", totalSinDesc
    Escribir "Forma de pago: ", formaPago
    Escribir "Descuento: Q", descuento
    Escribir "Total a pagar: Q", totalPagar
	
FinProceso
