using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double radioAr, baseAr, alturaAr, ladoAr, area;
            byte opcion;

            //Mostramos las opciones
            
            
                Console.WriteLine("1.  Area del circulo");
                Console.WriteLine("2.  Area del cuadrado");
                Console.WriteLine("3. Area del triangulo");
              


                Console.Write("Escoge una opcion y calcule su area  ");
                opcion = Convert.ToByte(Console.ReadLine());
            

            

            //while ((opcion< 1) || (opcion > 3));


            

            switch (opcion)
            {
                case 1:
                    Console.Write("Dame el radio de circulo:    ");
                    radioAr = Convert.ToByte(Console.ReadLine());
                    //Invocamos el metodo
                    area = Circulo(radioAr);
                    Console.WriteLine("El area es: {0}", area);
                    break;


                case 2:
                    Console.Write("Dame el valos de uno de los lados del cuadrado:   ");
                    ladoAr = Convert.ToByte(Console.ReadLine());
                    //Invocamos al metodo
                    area = Cuadrado(ladoAr);
                    Console.WriteLine("El area es: {0}", area);
                    break;

                case 3:
                    //Pedimos los valores de la base y la altura
                    Console.Write("Dame la base del triangulo:   ");
                    baseAr = Convert.ToByte(Console.ReadLine());

                    Console.Write("Dame la altura del triangulo:   ");
                    alturaAr = Convert.ToByte(Console.ReadLine());
                    //Invocamos al metodo
                    area = Triangulo(baseAr, alturaAr);
                    Console.WriteLine("El area es: {0}", area);

                    break;

              
                    



            }



        }

        //Metodo que calcula el area del circulo
        static double Circulo(double radioPa)

        {

            double area;
            area = Math.PI * (radioPa * radioPa);
            //regresamos el valor
            return area;

        }


        //Metodo que calcula el area del triangulo
        static double Triangulo(double basePa, double alturaPa)

        {

            double area;
            area =  (basePa * alturaPa) / 2;
            //regresamos el valor
            return area;

        }
        //Metodo que calcula el area del cuadrado
        static double Cuadrado(double ladoPa)

        {

            double area;
            area = ladoPa * ladoPa;
            //regresamos el valor
            return area;

        }

    }
}
