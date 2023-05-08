namespace Cuso_c_
{
    public class EjercicioSesion4
    {
        public void Ejerccio1()
        {
            Console.Write("Ingresa un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            int multiplicador = 1;

            while (multiplicador <= 10)
            {
                int resultado = numero * multiplicador;
                Console.WriteLine($"{numero} x {multiplicador} = {resultado}");

                multiplicador++;
            }
        }

        public void Ejerccio2() 
        {
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            string entrada;

            do
            {
                Console.Write("Ingresa un número (o 'q' para salir): ");
                entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int numero))
                {
                    if (numero > 0)
                    {
                        contadorPositivos++;
                    }
                    else if (numero < 0)
                    {
                        contadorNegativos++;
                    }
                }
                else if (entrada.ToLower() != "q")
                {
                    Console.WriteLine("Entrada inválida. Intenta nuevamente.");
                }
            }
            while (entrada.ToLower() != "q");

            Console.WriteLine($"Cantidad de números positivos: {contadorPositivos}");
            Console.WriteLine($"Cantidad de números negativos: {contadorNegativos}");
        }

        public void Ejercicio3()
        {
            Console.Write("Cantidad de figuras: ");
            int rep = int.Parse(Console.ReadLine());

            Console.WriteLine("\nResultado:\n");

            for (int r = 0; r < rep; r++)
            {
                Console.WriteLine($"Ingrese las dimensiones de la figura #{r+1}:");
                Console.Write("Ancho: ");
                int ancho = int.Parse(Console.ReadLine());
                Console.Write("Alto: ");
                int alto = int.Parse(Console.ReadLine());
                Console.Write($"Relleno (0 para no, 1 para sí): ");
                int relleno = int.Parse(Console.ReadLine());
                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        if (relleno == 1 || i == 0 || i == alto - 1 || j == 0 || j == ancho - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                } 
            }
        }
    }
}