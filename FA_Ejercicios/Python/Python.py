# -*- coding: utf-8 -*-
import math
import random

def ejercicio01():
    x = int(input("Ingrese x: "))
    y = int(input("Ingrese y: "))

    suma = x + y
    resta = x - y
    multiplicacion = x * y
    division = x / y  # En Python la división siempre devuelve float

    print("\nSuma:", suma)
    print("Resta:", resta)
    print("Multiplicación:", multiplicacion)
    print("División:", division)

def ejercicio02():
    num = float(input("Ingrese un número decimal: "))

    raiz_cuadrada = math.sqrt(num)
    redondeo = round(num)   # redondea al entero más cercano
    cubo = math.pow(num, 3)
    raiz_cubica = num ** (1/3)  # también se puede usar math.pow(num, 1/3)

    print("Raíz cuadrada:", raiz_cuadrada)
    print("Redondeo:", redondeo)
    print("Cubo:", cubo)
    print("Raíz cúbica:", raiz_cubica)

def ejercicio03():
    num = input("Ingrese un número: ")

    deci = float(num)
    entero = round(deci)  # redondeo al entero más cercano

    print("Resto:", entero % 2)
    print("División:", deci / 3)

def ejercicio04():
    edad = int(input("Ingrese la edad: "))

    if edad < 18:
        print("Menor de edad")
    elif edad <= 64:
        print("Adulto")
    else:
        print("Adulto mayor")

def ejercicio05():
    a = int(input("Ingrese un año: "))

    # Verificar si es bisiesto
    if (a % 4 == 0 and a % 100 != 0) or (a % 400 == 0):
        print("El año es bisiesto")
    else:
        print("El año no es bisiesto")

    # Verificar si es par o impar
    if a % 2 == 0:
        print("El año es par")
    else:
        print("El año es impar")

def ejercicio06():
    monto = float(input("Ingrese monto en soles: "))

    print("\n1. Dólares")
    print("2. Euros\n")

    opcion = int(input("Ingrese una opción: "))

    if opcion == 1:
        print("Dólares:", round(monto / 3.75, 2))
    elif opcion == 2:
        print("Euros:", round(monto / 4.05, 2))
    else:
        print("Opción incorrecta")

def ejercicio07():
    print("Bienvenidos al sistema de Áreas\n")
    print("1. Cuadrado")
    print("2. Rectángulo")
    print("3. Triángulo")
    print("4. Círculo\n")

    opcion = int(input("Ingrese una opción: "))

    if opcion == 1:
        lado = float(input("Ingrese lado: "))
        print("Área del cuadrado:", lado * lado)

    elif opcion == 2:
        base = float(input("Ingrese la base: "))
        altura = float(input("Ingrese la altura: "))
        print("Área del rectángulo:", base * altura)

    elif opcion == 3:
        base = float(input("Ingrese la base: "))
        altura = float(input("Ingrese la altura: "))
        print("Área del triángulo:", (base * altura) / 2)

    elif opcion == 4:
        radio = float(input("Ingrese el radio: "))
        print("Área del círculo:", round(math.pi * math.pow(radio, 2), 2))

    else:
        print("Opción incorrecta")

def ejercicio08():
    cantidad = int(input("¿Cuántos números ingresará? "))

    pares = 0
    impares = 0
    ceros = 0

    for i in range(1, cantidad + 1):
        numero = int(input(f"Ingrese el número {i}: "))

    if numero == 0:
        ceros += 1
    elif numero % 2 == 0:
        pares += 1
    else:
        impares += 1

    print("\nRESULTADOS")
    print("Cantidad de pares:", pares)
    print("Cantidad de impares:", impares)
    print("Cantidad de ceros:", ceros)

    input("\nPresione ENTER para salir...")  # pausa la consola

def ejercicio09():
    num = int(input("Ingrese un número entero: "))

    # Validar que sea mayor que 0
    while num <= 0:
        num = int(input("Error. Ingrese un número entero: "))

    # Imprimir tabla de multiplicar
    i = 1
    print()
    while i <= 12:
        print(f"{num} x {i} = {num * i}")
        i += 1

def ejercicio10():
    sp = 0  # suma de pares
    si = 0  # suma de impares

    while True:
        num = int(input("Ingrese un número positivo: "))

        if num == 0:
            break
        if num < 0:
            print("Error. Ingrese solo positivos:\n")
            continue

        if num % 2 == 0:
            sp += num
        else:
            si += num

    print("Suma de pares:", sp)
    print("Suma de impares:", si)

    input("\nPresione ENTER para salir...")  # pausa la consola

def ejercicio11():
    filas = int(input("Ingrese la cantidad de filas: "))
    columnas = int(input("Ingrese la cantidad de columnas: "))

    print()

    i = 1
    while i <= filas:
        j = 1
        while j <= columnas:
            print("* ", end="")  # end="" evita el salto de línea
            j += 1
        print()  # salto de línea al terminar la fila
        i += 1

    input("\nPresione ENTER para salir...")

def ejercicio12():
    # Crear contraseña
    contra = input("Genere una contraseña: ")

    intentos = 3

    print("------------------------")
    print("--Valida tu contraseña--")
    print("------------------------")

    while intentos > 0:
        passw = input("Ingresa tu contraseña: ")

        if contra == passw:
            print("Acceso concedido!")
            exit()  # termina el programa
        else:
            intentos -= 1
            print(f"Contraseña incorrecta! Le restan {intentos} intentos")

    print("Acceso denegado. Ya culminó todos sus intentos!")

    input("\nPresione ENTER para salir...")

def ejercicio13():
    p = i = 0
    while True:
        num = int(input("Ingrese un número: "))
        
        if num < 0:
            break
        if num % 2 == 0:
            p += 1
        else:
            i += 1
            
    print("\nCantidad de pares: ",p)
    print("Cantidad de impares: ",i)

def ejercicio14():
    secreto = random.randint(1,20)
    intentos = 3

    print("***********************************")
    print("* BIENVENIDOS AL JUEG0 ADIVINADOR *")
    print("*                                 *")
    print("* 1. Ud. deberá adivinar el número entre 1 y 20")
    print("* 2. Ud. tiene 3 intentos *")
    print("* 3. Por cada falla se otorgará una pista *")
    print("*******************************************")

    while (intentos > 0):
        num = int(input(f"\nIngrese un número (Intento {intentos}): "))

        if num == secreto:
            print("\nFelicidades. Adivinaste!")
            break
        else:
            intentos -= 1
            if num < secreto:
                print("El número es mayor.")
            else:
                print("El número es menor.")
    else:
        print(f"\nNo lograste adivinar el número secreto {secreto}")

def ejercicio15():
    import os  # Para limpiar la consola

    opc = ""
    num = 0

    while True:
        # Limpiar pantalla (funciona en Windows)
        os.system('cls')

        suma = 0
        num = int(input("Ingrese un número: "))

        for i in range(1, num + 1):
            suma += i
            print(i, end=" ")

        print("\nSuma:", suma)

        opc = input("\n¿Desea continuar? (Presione N para salir): ")
        if opc == "N":
            break

ejercicio15()