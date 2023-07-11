namespace CambiosDeTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = CrearMetodo("Ingrese una temperatura en grados celsius=");
            double farenheit = ConvertiraFarenheit(celsius);
            double rankine = ConvertiraRankine(celsius);
            Console.WriteLine($"{celsius} grados celsius es igual a {farenheit} grados Farenheit");
            Console.WriteLine($"{celsius} grados celsius es igual a {rankine} grados Rankine");
        }
        
        private static double ConvertiraRankine(double celsius) => (celsius + 273.15) * 9 / 5;
        

        private static double ConvertiraFarenheit(double celsius) => (celsius * 9 / 5) + 32;
     
        private static double CrearMetodo(string Mensaje)
        {
            double Nro = 0;
            do
            {
                Console.Write(Mensaje);
                string strconsole = Console.ReadLine();
                if (!double.TryParse(strconsole,out Nro))
                {
                    Console.WriteLine("Numero mal igresado");
                }
                else
                {
                    break;
                }
                
                

            } while (true);

            return Nro;
        }
       
    }
}