using System;

namespace midterm {
    class Program {
        static void Main(string[] args) {
           double x1 = double.Parse(Console.ReadLine());
           double y1 = double.Parse(Console.ReadLine());
           double w1 = double.Parse(Console.ReadLine());
           double h1 = double.Parse(Console.ReadLine());

           double x2 = double.Parse(Console.ReadLine());
           double y2 = double.Parse(Console.ReadLine());
           double w2 = double.Parse(Console.ReadLine());
           double h2 = double.Parse(Console.ReadLine());

           if ((w1-w2 != 0) && (h1-h2 != 0) && (y1-y2>=h1 || y1-y2>=h2 || y2-y1>=h1 || y2-y1>=h2 || x1-x2>=w1 || x1-x2>=w2 || x2-x1>=w1 || x2-x1>=w2)) {
            double wr = ((w1)-(w2)) * ((h1)-(h2));
            double wr1 = (w2-w1)*(h2-h1);

            if (wr > 8) {
                Console.WriteLine("Too Much Overlapping");
            } else {
                Console.WriteLine("Not much Overlapping");
            }
           } else {
            Console.WriteLine("No Overlapping");
           }
        }
    }
}