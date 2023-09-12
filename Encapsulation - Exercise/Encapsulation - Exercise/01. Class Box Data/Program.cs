namespace P01.ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           
           
            try
            {
                double lenght = double.Parse(Console.ReadLine());
                double widht = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Box box=new Box(lenght, widht, height);
                Console.WriteLine(box);
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
                return; 

            
            }
            

        }
    }
}