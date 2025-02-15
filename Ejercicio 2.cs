using System;

int numInt1, numInt2;
decimal numDecimal1, numDecimal2;
float numFloat1, numFloat2;
short numInt16_1, numInt16_2;
byte numByte1, numByte2;

Console.WriteLine("Ingresa dos números enteros (int): ");
Console.Write("Primer número (int): ");
numInt1 = int.Parse(Console.ReadLine());
Console.Write("Segundo número (int): ");
numInt2 = int.Parse(Console.ReadLine());

Console.WriteLine("\nOperaciones con enteros (int):");
Console.WriteLine($"Suma: {numInt1} + {numInt2} = {numInt1 + numInt2}");
Console.WriteLine($"Resta: {numInt1} - {numInt2} = {numInt1 - numInt2}");
Console.WriteLine($"Multiplicación: {numInt1} * {numInt2} = {numInt1 * numInt2}");
Console.WriteLine($"División: {numInt1} / {numInt2} = {(double)numInt1 / numInt2}");

Console.WriteLine("\nIngresa dos números decimales (decimal): ");
Console.Write("Primer número (decimal): ");
numDecimal1 = decimal.Parse(Console.ReadLine());
Console.Write("Segundo número (decimal): ");
numDecimal2 = decimal.Parse(Console.ReadLine());

Console.WriteLine("\nOperaciones con decimales (decimal):");
Console.WriteLine($"Suma: {numDecimal1} + {numDecimal2} = {numDecimal1 + numDecimal2}");
Console.WriteLine($"Resta: {numDecimal1} - {numDecimal2} = {numDecimal1 - numDecimal2}");
Console.WriteLine($"Multiplicación: {numDecimal1} * {numDecimal2} = {numDecimal1 * numDecimal2}");
Console.WriteLine($"División: {numDecimal1} / {numDecimal2} = {numDecimal1 / numDecimal2}");

Console.WriteLine("\nIngresa dos números de punto flotante (float): ");
Console.Write("Primer número (float): ");
numFloat1 = float.Parse(Console.ReadLine());
Console.Write("Segundo número (float): ");
numFloat2 = float.Parse(Console.ReadLine());

Console.WriteLine("\nOperaciones con float:");
Console.WriteLine($"Suma: {numFloat1} + {numFloat2} = {numFloat1 + numFloat2}");
Console.WriteLine($"Resta: {numFloat1} - {numFloat2} = {numFloat1 - numFloat2}");
Console.WriteLine($"Multiplicación: {numFloat1} * {numFloat2} = {numFloat1 * numFloat2}");
Console.WriteLine($"División: {numFloat1} / {numFloat2} = {numFloat1 / numFloat2}");

Console.WriteLine("\nIngresa dos números enteros pequeños (int16): ");
Console.Write("Primer número (int16): ");
numInt16_1 = short.Parse(Console.ReadLine());
Console.Write("Segundo número (int16): ");
numInt16_2 = short.Parse(Console.ReadLine());

Console.WriteLine("\nOperaciones con int16:");
Console.WriteLine($"Suma: {numInt16_1} + {numInt16_2} = {numInt16_1 + numInt16_2}");
Console.WriteLine($"Resta: {numInt16_1} - {numInt16_2} = {numInt16_1 - numInt16_2}");
Console.WriteLine($"Multiplicación: {numInt16_1} * {numInt16_2} = {numInt16_1 * numInt16_2}");
Console.WriteLine($"División: {numInt16_1} / {numInt16_2} = {(double)numInt16_1 / numInt16_2}");

Console.WriteLine("\nIngresa dos números pequeños (byte): ");
Console.Write("Primer número (byte): ");
numByte1 = byte.Parse(Console.ReadLine());
Console.Write("Segundo número (byte): ");
numByte2 = byte.Parse(Console.ReadLine());

Console.WriteLine("\nOperaciones con byte:");
Console.WriteLine($"Suma: {numByte1} + {numByte2} = {numByte1 + numByte2}");
Console.WriteLine($"Resta: {numByte1} - {numByte2} = {numByte1 - numByte2}");
Console.WriteLine($"Multiplicación: {numByte1} * {numByte2} = {numByte1 * numByte2}");
Console.WriteLine($"División: {numByte1} / {numByte2} = {(double)numByte1 / numByte2}");
