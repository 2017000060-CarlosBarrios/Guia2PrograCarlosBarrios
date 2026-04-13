Algoritmo MENU
	definir comida Como Caracter
	Escribir "menu de comida"
	escribir Sin Saltar "Que se le antoja hoy??: "
	leer comida
	
	Segun letra Hacer
		"Hamburguesa":
			Escribir "Servido su hamburguesa"
		"Pizza":
			escribir "servida su pizza"
		"Pollo frito":
			escribir "servido su pollo frito"
		"Ensalada":
			Escribir "servida su ensalada"
		De Otro Modo:
			Escribir "no tenemos eso en el menu"
	Fin Segun
FinAlgoritmo
