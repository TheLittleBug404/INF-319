from tokenize import Double


print ("Introdusca 2 numeros: ")
a = int(input("Introdusca el primer numero: "))
b = int(input("Introdusca el segundo numero: "))
def suma(a,b):
    return a+b
def resta(a,b): 
    return a-b
def multiplicacion(a,b): 
    return a*b
def division (a,b):
    if b != 0:  
        d = a/b
        return d
    else:
        return "no existe division entre cero"
print("La suma de los numeros es: ",suma(a,b))
print("La resta de los numeros es: ",resta(a,b))
print("La multiplicacion de los numeros es: ",multiplicacion(a,b))
print("La division de los numeros es: ",division(a,b))
