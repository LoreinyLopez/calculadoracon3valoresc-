namespace Calculadoracon3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora con 3 numeros");
            Console.WriteLine();
            
            double valor1, valor2, valor3, suma, resta, multiplica, divide;

            
            Console.WriteLine("Introduzca el primer valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer valor: ");
            valor3 = Convert.ToDouble(Console.ReadLine());


            suma = valor1 + valor2 + valor3;
            resta = valor1 - valor2 - valor3;
            multiplica = valor1 * valor2 * valor3;
            divide = valor1 / valor2 / valor3;

            //Salida de la información
            Console.WriteLine("el resultado de la suma es:" + (suma));
            Console.WriteLine("El resultado de la resta es: " + resta);
            Console.WriteLine($"El resultado de la multiplicación es {multiplica}");
            Console.WriteLine("El resultado de la división es: " + divide.ToString());
        }
    }
}
