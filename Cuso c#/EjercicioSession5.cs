namespace Cuso_c_
{
    public class EjercicioSession5
    {
        public void Ejercicio1()
        {
            Console.WriteLine("Ingrese los datos del cliente:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Tiene Cupón? (deje en blanco si no tiene): ");
            string cupon = Console.ReadLine();

            bool tieneDescuento = !string.IsNullOrEmpty(cupon);

            double precioProducto = 100.0;
            double precioFinal = tieneDescuento ? precioProducto * 0.8 : precioProducto;

            Console.WriteLine("---- Detalles del pedido ----");
            Console.WriteLine("Cliente: " + nombre);
            Console.WriteLine("Email: " + email);

            if (tieneDescuento)
            {
                Console.WriteLine("¡Felicidades! Tiene un cupón de descuento aplicado.");
                Console.WriteLine("Precio rebajado: $" + precioFinal);
            }
            else
            {
                Console.WriteLine("No tiene cupón de descuento.");
                Console.WriteLine("Precio sin descuento: $" + precioFinal);
            }
        }

        public void Ejercicio2()
        {
            List<string> list = new List<string>() { "C#", "Javascript", "Java", "Kotlin"};

            Console.WriteLine($"Cual es tu lenguaje favorito presiona el numero: 1: C#, 2: Javascript, 3: Java, 4: Kotlin");
            var select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 1: Console.WriteLine("Hola Mundo! -> C#");
                    break;
                case 2: Console.WriteLine("Hola Mundo! -> Javascript");
                    break;
                case 3:
                    Console.WriteLine("Hola Mundo! -> Java");
                    break;
                case 4:
                    Console.WriteLine("Hola Mundo! -> Kotlin");
                    break;
                default:
                    Console.WriteLine("El lenguaje no esta en la lista :(");
                    break;
            }
        }
    }
}
