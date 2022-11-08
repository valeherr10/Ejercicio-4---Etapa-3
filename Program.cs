namespace Ejercicio_4___Etapa_3
{

    // Valentina Herrera Rocha

    class Program
    {
        static void Main(string[] args)
        {

            Entidad secretaria = new Entidad();

            int seguir = 1;
            while (seguir == 1)
            {
                Console.WriteLine("************* MENU *************");
                Console.WriteLine(" 1. Agregar persona");
                Console.WriteLine(" 2. Buscar personas");
                Console.WriteLine(" 3. Calcula IMC");
                Console.Write(" Ingrese el número de la opcion a elegir: ");
                int opcion = int.Parse(Console.ReadLine()); 

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine(" 1. Agregar persona");
                            Console.Write(" Ingrese la ID de la persona: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write(" Ingrese el nombre: ");
                            String nombre = Console.ReadLine();
                            Console.Write(" Ingrese el peso: ");
                            double peso = Double.Parse(Console.ReadLine());
                            Console.Write(" Ingrese la altura: ");
                            double altura = Double.Parse(Console.ReadLine());
                            secretaria.agregar(id, nombre, peso, altura);
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine(" 2. Buscar personas");
                            Console.Write(" Ingrese la ID de la persona a buscar en la lista: ");
                            int id = int.Parse(Console.ReadLine());
                            secretaria.buscar(id);
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine(" 3. Calcula IMC");
                            Console.Write(" Ingrese la ID de la persona para calcular su IMC: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write(secretaria.calculaIMC(id));
                            break;
                        }
                    default:
                        {
                            Console.Write(" La opción no es valida ");
                            break;
                        }
                }

                Console.WriteLine("\n Si desea volver al menú, escriba 1 ");
                Console.WriteLine(" Si desea cerrar, escriba 2 ");
                seguir = int.Parse(Console.ReadLine()); 


            }


        }


    }

}