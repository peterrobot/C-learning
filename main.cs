using System;

public class helloworld{
    public static void Main(string[] args){
    Console.WriteLine("Hello World!");
    double r = Convert.ToDouble(Console.ReadLine());
    Math.circle a = new Math.circle(r);
    Console.WriteLine(a.squre());
    Console.ReadLine();
    }
}

namespace Math{
    public class math{
        protected const double pi = 3.14;
        protected const double e = 1.7;
    }

    public class Asix : math{
        protected double x,y;
    }

    public class circle : math{
        private double r;

        public circle(double R){
            r = R;
        }
        public void set_value(double Input){
            r = Input;
        }
        public double squre(){
            return r*r*pi;
        }
    }

    public class rectangle : math{
        private double length;
        private double width;
        public rectangle(double L,double W){
            length = L;
            width = W;
        }

        public void set_value(double L,double W){
            length = L;
            width = W;
        }

        public double squre(){
            return length * width;
        }
    }
}