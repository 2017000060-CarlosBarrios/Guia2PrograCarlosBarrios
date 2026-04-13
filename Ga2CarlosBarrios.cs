internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*******************");
        Console.WriteLine("Dias de la semana");
        Console.WriteLine("*******************");

        int dia;
        Console.WriteLine("Digite un valor entero del 1 al 7");
        dia=Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("lUNES");
                break;
            case 2:
                Console.WriteLine("MARTES");
                break;
            case 3:
                Console.WriteLine("MIERCOLES");
                break;
            case 4:
                Console.WriteLine("JUEVES");
                break;
            case 5:
                Console.WriteLine("VIERNES");
                break;
            case 6:
                Console.WriteLine("SABADO");
                break;
            case 7:
                Console.WriteLine("DOMINGO");
                break;
            default:
                Console.WriteLine("Escriba un valor valido del 1 al 7");
                break;
        }
    }
}