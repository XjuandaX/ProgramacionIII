using System;

namespace Guia_1
{
    class Ejercicio_3
    {

        public string nombre;
        public int numeroDeCuenta;
        public float saldoInicial, retirar, consignar;

        public void CapturarDatos()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 2); Console.WriteLine("M A Q U I N A   R E G I S T R A D O R A");
            Console.SetCursorPosition(16, 6); Console.Write("nombre: ");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(16, 8); Console.Write("numero de cuenta: ");
            numeroDeCuenta = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(16, 10); Console.Write("saldo inicial: ");
            saldoInicial = float.Parse(Console.ReadLine());
        }

        public void retirarYConsignar()
        {
            int op;

            do
            {
            Console.Clear();
            Console.SetCursorPosition(40, 2); Console.WriteLine("M A Q U I N A   R E G I S T R A D O R A");
            Console.SetCursorPosition(16, 6); Console.Write("que desea hacer?: ");
            Console.SetCursorPosition(16, 8); Console.Write("1. retirar");
            Console.SetCursorPosition(16, 10); Console.Write("2. consignar");
            Console.SetCursorPosition(16, 12); Console.WriteLine("3. finalizar");
            Console.SetCursorPosition(16, 24); Console.Write("digite una opcion: ");
            op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
            {
                case 1:
                        Console.SetCursorPosition(16, 14); Console.Write("cuanto desea retirar?: ");
                        retirar = float.Parse(Console.ReadLine());
                        if (retirar > saldoInicial || retirar < 0)
                        {
                            Console.SetCursorPosition(16, 16); Console.Write("numero invalido");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            saldoInicial -= retirar;
                        }
                        break;
                case 2:
                        Console.SetCursorPosition(16, 14); Console.Write("cuanto desea consignar?: ");
                        consignar = float.Parse(Console.ReadLine());
                        if (consignar < 0)
                        {
                            Console.SetCursorPosition(16, 16); Console.Write("no se puede consignar valores negativos");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            saldoInicial += consignar;
                        }
                        break;

                case 3:
                        break;
                }
            } while (op != 3);
        }

        public void ImprimirResultado()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 2); Console.WriteLine("M A Q U I N A   R E G I S T R A D O R A");
            Console.SetCursorPosition(16, 6); Console.Write("nombre: " + nombre);
            Console.SetCursorPosition(16, 8); Console.Write("numero de cuenta: " + numeroDeCuenta);
            Console.SetCursorPosition(16, 10); Console.Write("saldo final: " + saldoInicial);
            Console.ReadKey();
        }

    }
}