using System;

namespace InfoRetrieve
{
    class Retancles{
        double length;
        double width;

        public double GetLength(){
            length = Convert.ToDouble(Console.ReadLine());
           
            return length;
          
        }
        public double GetWidth()
        {
            width = Convert.ToDouble(Console.ReadLine());
            return width;
        }

        public double GetArea(double length,double width){
            
            return length * width;
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Retancles retancle =new Retancles();
            var length = retancle.GetLength();
            var width = retancle.GetWidth();
            var area = retancle.GetArea(length,width);
            Console.WriteLine(area);





        }
    }
}
