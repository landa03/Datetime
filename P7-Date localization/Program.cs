using System;

namespace P7_Date_localization
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir al usuario que ingrese una fecha y hora
            Obtener la fecha "dentro de 2 horas y 30 minutos"
            Mostrar la fecha en horario UTC
            Mostrar la fecha/hora en horario de otro país y mencionar el nombre del país
            Si la fecha ingresada está en el futuro, mostrar cuántos días faltan. Si la fecha ingresada está en el pasado, mostrar cuántos días han transcurrido.*/
            System.Console.WriteLine("porfabor escriba una fecha en el formato yyyy,dd,mm");
            System.Console.WriteLine("empesemos por el a;o");
            int year = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("ahora el dia");
            int dei = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("ahora el mes");
            int month = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("ahora la hora");
            //string date = "01:01:01";
            string ours = Convert.ToString(Console.ReadLine());
            ours = DateTime.ParseExact(ours);
            //System.Globalization.Calendar ToDateTime (int ours); // todo transfotmar un valor (int) a Global.Calendar

            var date1 = new DateTime(year, dei, month, ours);
            //DateTime date1 = DateTime.Now;
            System.Console.WriteLine(date1);
        }
    }
}
