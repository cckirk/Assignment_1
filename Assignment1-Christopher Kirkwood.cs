using System;

namespace assignment_1
{
    class Cirle
		
    {
        public static double radius;
		public Circle(double Radius)
		{
			this.radius = Radius;
		}   
        public static double circumfrence()
        {
            double circumfrence = 2 * Math.PI * radius;
            return circumfrence;
        }
        public static double area()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
	class Triangle
	{
		private double side1, side2, side3;
		public triangle(double Side1, double Side2, double Side3)
		{
			double side1 = Side1;
			double side2 = Side2;
			double side3 = Side3;
		}
		public triangle()
		{
			double side1 = 3.0;
			double side2 = 4.0;
			double side3 = 5.0;
		}
		public perimeter()
		{
			public double perim = side1 + side2 + side3;
			return perim;
		}
		public area()
		{
			double p = ((side1 + side2 + side3)/2.0);
		    double area = Math.Sqrt(p*((p-side1)*(p-side2)*(p-side3)));
			return area;
		}
		public height()
		{
			double smallest = (side1 + side2 + side3);
			if (smallest >= side1 - side2 && side1 - side2 >= 0)
			{
				smallest = side2;
			}
			else if (side1 - side2 < 0)
			{
				smallest = side1;
			}
			else if (smallest - side3 >= 0)
			{
				smallest = side3;
			}
			double height = (2 * Triangle.area())/smallest;
			return height;
		}
	class rectangle
	{
		private double height;
		private double width;
		
		public Rectangle(double height, double width)
		{
			this.height = height;
			this.width = width;
		}
		public double perimeter()
		{
			double perimeter = 2 * height + 2 * width;
			return perimeter;
		}
		public double area()
		{
			double area = height * width;
			return area;
		}
	class driver
	{
		public void circle_driver()
		{
			double i = 0.0;
			while (i < 10)
			{
				Console.WriteLine("Circle at entry "+ i + "has area " + Circle.area() + " and circumfrence " + Circle.circumfrence());
				i += 1.0;
			}
		}
        circle_driver();
		public void rectangle_driver()
		{
			double i = 0.0;
			double j = 0.0;
			while (i < 4)
			{
				while (j < 4)
				{
					Console.WriteLine("Rectangle at entry "+ i + "X" + j + "has perimeter" + rectangle.perimeter() + " and circumfrence " + rectangle.area());
				}
				j += 1;
			}
			i += 1;
		}
        rectangle_driver();
		Triangle triangle1 = triangle(18,30,24);
		public void triangle_driver()
		{
			Console.WriteLine("Area of triangle is " + triangle.area() + " perimeter is " + triangle.perimeter + "and its height is " + triangle.height());
		}
		Triangle triangle1 = Triangle.triangle();
		triangle_driver();
	}
		
}
}