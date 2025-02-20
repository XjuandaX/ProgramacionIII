using System;

namespace Guia_1
{
    public class MenuPrincipal
    {
        
        public void Menu()
        {
            int op;
            do
            {
                 Console.Clear();
                Console.SetCursorPosition(48,2); Console.Write("M E N U   P R I N C I P A L");
                Console.SetCursorPosition(16,6); Console.Write("1. Gestion de Notas");
                Console.SetCursorPosition(16,8); Console.Write("2. Calcular el número de pulsaciones ");
                Console.SetCursorPosition(16,10); Console.Write("3. información financiera ");
                Console.SetCursorPosition(16,13); Console.Write("4. Salir ");

                Console.SetCursorPosition(16,19); Console.Write("digite una opcion: ");
                Console.SetCursorPosition(38,19); op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        Ejercicio_1 ejercicio_1 = new Ejercicio_1();
                        ejercicio_1.MenuGestionEstudiante();
                        break;
                    case 2:
                        Ejercicio_2 ejercicio_2 = new Ejercicio_2();
                        ejercicio_2.CapturarDatos();
                        ejercicio_2.CalcularPulsaciones();
                        ejercicio_2.ImprimirResultado();
                        break;
                    case 3:
                        Ejercicio_3 ejercicio_3 = new Ejercicio_3();
                        ejercicio_3.CapturarDatos();
                        ejercicio_3.retirarYConsignar();
                        ejercicio_3.ImprimirResultado();
                        break;
                    case 9:
                        Console.Clear();
                        Console.SetCursorPosition(5, 2); Console.WriteLine("gracias por usar mi codigo :D");
                        Console.ReadKey();
                        break;
                }

            } while (op!=9);

        }
    }
}
