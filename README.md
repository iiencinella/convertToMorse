# CÓDIGO MORSE

Nivel: Medio

Link: [está en GitHub](https://github.com/mouredev/Weekly-Challenge-2022-Kotlin/blob/main/app/src/main/java/com/mouredev/weeklychallenge2022/Challenge9.kt)

## Problema

Enunciado: Crea un programa que sea capaz de transformar texto natural a código morse y viceversa.

- Debe detectar automáticamente de qué tipo se trata y realizar la conversión.

- En morse se soporta raya "—", punto ".", un espacio " " entre letras o símbolos y dos espacios entre palabras "  ".

- El alfabeto morse soportado será el mostrado en <https://es.wikipedia.org/wiki/Código_morse>.

## Discusión

Para resolver este ejecricio vamos a tener que usar un diccionario de equivalencias ya que sabemos que a cada caracter de entrada le corresponde un símbolo específico y no existe un algoritmo (como sucede en las conversiones numéricas) en las cuales, con un par de pasos, podemos saber rápidamente el resultado final. La lingüística es compleja y varía del lugar en donde te encuentres.

El diccionario será para guardar tuplas [valor, código]. El valor será el caracter alfanumérico y el código serán los símbolos del código Morse y viceversa.

También tenemos que darnos cuenta si lo que el usuario ingresa

Ya teniendo en mente que vamos a usar un diccionario para convertir las letras en símbolos, vamos a pensar en una forma de que la conversión sea sencilla y limpia.

- Conversión a Código Morse:
Vamos a recorrer la cadena de caracteres, buscamos el símbolo en el diccionario y agregamos el símbolo a una nueva cadena. Si nos encontramos con un caracter de espacio, lo pasaremos a la nueva cadena. No nos olvidemos que hay que agregar un espacio entre símbolos y 2 espacios entre palabras.

- Conversión a lenguaje alfanumérico:
Recorreremos el código

## Conclusión

Capaz que en otro lenguaje sea más sencillo de resolver, pero en C# hay que saber manipular diccionarios y expresiones regulares.

Lo que terminé haciendo es tomar la entrada y evaluar si se ingresó algún caracter alfanumérico. Si se ingresaron valores alfanuméricos, realizo la conversión a Braile buscando en el diccionario la clave (que es alfanumérica) para pasar el valor (que es el código braile equivalente) y lo muestro.

En caso de que detecte que se ingresaron caracteres del código Braile, realizo la conversión buscando el valor (que es el código braile) para pasar la clave (que es el equivalente alfanumérico).

La conversión de alfanumérico a braile no es complicado, pero lo difícil fue la conversión inversa, ya que tuve que averiguar como obtener la clave del diccionario pasando el valor.
