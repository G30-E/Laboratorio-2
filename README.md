
# Tarea-2-progra-1
# Respuestas a preguntas sobre programación

Este archivo contiene respuestas a preguntas clave sobre programación y tipos de datos.

## ¿Para qué crees que se usan los operadores lógicos en programación?

Los **operadores lógicos** en programación se utilizan para realizar operaciones con condiciones booleanas (verdaderas o falsas). Se emplean para **combinaciones de condiciones**, lo que permite tomar decisiones más complejas en el flujo del programa.

### Los operadores lógicos más comunes son:
- **AND (`&&`)**: Evalúa si ambas condiciones son verdaderas. Retorna `true` solo si ambas lo son.
- **OR (`||`)**: Evalúa si al menos una de las condiciones es verdadera. Retorna `true` si alguna lo es.
- **NOT (`!`)**: Invierte el valor de una condición. Si una condición es `true`, se convierte en `false`, y viceversa.

Estos operadores permiten realizar **comparaciones más complejas**, como verificar si una persona es mayor de edad y vive en un lugar específico, o si dos variables cumplen con ciertas condiciones antes de ejecutar una acción en un programa.

## ¿Por qué es importante declarar correctamente el tipo de dato de una variable?

Es importante declarar correctamente el tipo de dato de una variable por las siguientes razones:

1. **Precisión y eficiencia**: El tipo de dato define cuánta memoria se usa para almacenar la variable y cómo se manipulan sus valores. Usar el tipo incorrecto puede resultar en errores de cálculo o pérdida de información.
   
2. **Prevención de errores**: Al declarar un tipo de dato adecuado, el compilador puede detectar y prevenir errores al intentar asignar un valor incorrecto, como intentar almacenar texto en una variable de tipo numérico.

3. **Mejora de la legibilidad y mantenimiento del código**: Los tipos de datos correctos permiten que otros programadores (o tú mismo en el futuro) comprendan mejor el propósito de las variables, haciendo el código más claro y fácil de mantener.

## Enunciado 1: Clasificación de edad

**Indicaciones:**
Crea un programa que clasifique a una persona según su edad en una de las siguientes categorías:

- **Menos de 12 años**: Niño
- **Entre 12 y 17 años**: Adolescente
- **Entre 18 y 59 años**: Adulto
- **60 años o más**: Adulto mayor

El programa debe pedir al usuario que ingrese su edad y, dependiendo del valor ingresado, debe mostrar el mensaje correspondiente para cada categoría.

### ¿Qué estructura usarías? `if-else` o `switch`? ¿Por qué?

**Respuesta:**

En este caso, **usaría la estructura `if-else`** porque estamos trabajando con **rangos de valores** para la edad (por ejemplo, "menor que 12", "entre 12 y 17", etc.), y el `switch` no es adecuado para comparar rangos. El `switch` funciona mejor cuando se comparan valores exactos, no rangos continuos.

El uso de **`if-else`** es más adecuado y flexible, ya que permite verificar los rangos de edad de manera clara y sencilla. Además, con `if-else` el código es más fácil de leer y mantener cuando se manejan condiciones basadas en rangos de valores.


## Enunciado 2: Día de la semana

**Indicaciones:**
Se quiere crear un programa que reciba un número del 1 al 7 y devuelva el nombre del día correspondiente:

- 1 = Lunes
- 2 = Martes
- 3 = Miércoles
- 4 = Jueves
- 5 = Viernes
- 6 = Sábado
- 7 = Domingo

### ¿Qué estructura usarías? `if-else` o `switch`? ¿Por qué?

**Respuesta:**

En este caso, **usaría la estructura `switch`**, ya que el número que se ingresa es un valor discreto entre 1 y 7, y el `switch` es ideal para comparar una única variable con varios valores posibles. El `switch` permite escribir un código más limpio y directo cuando tenemos varios casos específicos que comprobar, como en este ejemplo de los días de la semana.

## Enunciado 3: Verificación de acceso

**Indicaciones:**
Un usuario intenta iniciar sesión en una aplicación. Debes verificar lo siguiente:

- Si el usuario ingresó el nombre y la contraseña correctos, mostrar "Acceso concedido".
- Si solo ingresó el nombre correcto pero la contraseña es incorrecta, mostrar "Contraseña incorrecta".
- Si el nombre de usuario no existe, mostrar "Usuario no registrado".

### ¿Qué estructura usarías? `if-else` o `switch`? ¿Por qué?

**Respuesta:**

En este caso, **usaría la estructura `if-else`**. Esto se debe a que las condiciones que estamos evaluando no son valores discretos, sino una combinación de la verificación de la existencia del nombre de usuario y la validez de la contraseña. El `if-else` es más adecuado para situaciones en las que se están evaluando **condiciones complejas** y **en combinación** (como en este caso con nombre de usuario y contraseña). Además, con `if-else` podemos controlar claramente todos los posibles casos de manera más detallada.



