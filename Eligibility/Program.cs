namespace Eligibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the marks obtained in Physics :");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry :");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics :");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total marks of Maths, Physics and Chemistry : {0}", math + physics + chemistry);
            Console.WriteLine("Total marks of Maths and  Physics : {0}", math + physics);

            if (math >= 65)
                if (physics >= 55)
                    if (chemistry >= 50)
                        if ((math + physics + chemistry) >= 180 || (math + physics) >= 140)
                            Console.WriteLine("The candidate is eligible for admission.\n");
                        else
                            Console.WriteLine("The candidate is not eligible.");
                    else
                        Console.WriteLine("The candidate is not eligible.");
                else
                    Console.WriteLine("The candidate is not eligible.");
            else
                Console.WriteLine("The candidate is not eligible.");
        }
    }
}