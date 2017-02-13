using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main()
        {

            int iOption;

            Console.Write("Este programa esta a punto de comenzar :D Presione una tecla para continuar");
            Console.Write("\n\nEscoga la opcion que desee a continuacion :");
            Console.Write("\n1 - Productos matematicos");
            Console.Write("\n2 - Conocer el Mes");
            Console.Write("\n3 - Ordenar los numeros");
            Console.Write("\n4 - Calculos de años de antiguedad");
            Console.Write("\n5 - Calculo de ventas de tinenda");


            iOption = Convert.ToInt32(Console.ReadLine());

            if(iOption == 1)
            {
                numCalculation();
            }
            else if(iOption == 2)
            {
                monthNumber();
            }
            else if (iOption == 3)
            {
                Console.Clear();
                Console.Write("funciono");
                Console.ReadKey();
            }
            else if (iOption == 4)
            {
                Console.Clear();
                Console.Write("funciono");
                Console.ReadKey();
            }
            else if(iOption == 5)
            {
                Console.Clear();
                Console.Write("funciono");
                Console.ReadKey();
            }
            else{
                Console.Clear();
                Console.Write("porfavor ingrese un numero que este en las opciones");
                Console.ReadKey();
                Main();
            }
           

            
        }

        static void numCalculation()
        {
            Console.Clear();

            float firstNumber;
            float secondNumber;

            Console.Write("ingrese el primer numero : ");
            firstNumber = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero : ");
            secondNumber = float.Parse(Console.ReadLine());

            Console.Write("\nEl resultado de la suma de sus dos numeros es : " + (firstNumber + secondNumber));
            Console.Write("\nEl resultado de la resta de sus dos numeros es : " + (firstNumber - secondNumber));
            Console.Write("\nEl resultado de la multiplicacion de sus dos numeros es : " + (firstNumber * secondNumber));
            Console.Write("\nEl resultado de la division de sus dos numeros es : " + (firstNumber / secondNumber));
            Console.ReadKey();
            Main();

        }

        static void monthNumber()
        {
            Console.Clear();

            int monthSelection;
            string[] months = new string[12] { "Enero,", "Febrero","Marzo","Abril","Mayo","junio","julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre" };

            Console.Write("Calculo de meses segun el numero");
            Console.Write("\nIngrese el numero del mes : ");
            monthSelection = Convert.ToInt32(Console.ReadLine());

            if(monthSelection == 0 || monthSelection > 12)
            {
                Console.Write("Ha ingresado un numero incorrecto, porfavor ingrese un numero entre 1 y 12 \nPresiones una tecla para continuar");
                Console.ReadKey();
                monthNumber();
            }
            else
            {
                Console.Write("El mes correspondiente es : " + months[monthSelection - 1]);
                Console.ReadKey();
                Main();
            }

        }

        static void sortingNumbers()
        {
            Console.Clear();

            int[] numbersSort = new int[5];

            Console.Write("Ingrese 5 numeros y los ordenaremos a continuacion  : ");

            


        }
    }
}
