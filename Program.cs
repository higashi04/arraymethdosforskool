using System;

namespace arrayMethodsUTEL
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Ingrese un número entero: ");
           int userValue = int.Parse(Console.ReadLine()); //el número ingresado por el usuario es guardado en una variable
           if (userValue <= 10 && userValue > 0) //valida que el número ingresado sea igual o menor a 10 y mayor que 0
           {
                int[,] rectArray = new int[userValue,userValue]; //la variable que registra el número dado por el usuario es usada para definir el tamaño del arreglo
                Console.WriteLine("Los valores del arreglo son:");
                for (int file = 0; file < rectArray.GetLength(0); file++)
                {   
                    if (file > 0) {Console.WriteLine(" " + file);}; //Se utiliza un condicional para evitar que se imprima la primer línea con valor de 0
                    for (int column = 0; column < rectArray.GetLength(1); column++)
                    {
                        int colValue = column + file + 1;
                        Console.Write(" " + colValue );
                    };
                };
                Console.ReadKey();
           } 
                else
           {
               Console.WriteLine("El valor necesita ser igual o menor a 10.");
               Console.ReadKey();
           };
          


           
        }
            
    }
}
