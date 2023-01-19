

namespace Lessons // Note: actual namespace depends on the project name.
{
    internal class Gen_arith
    {
        static void Main()
        {
            double result;
            int numb;
            int sum = 0;
            int count = 0;
            Console.WriteLine("Вводите числа для расчета. Как только закончите, нажмите Enter");
            try
            {
                while (true)
                {
                    numb = Convert.ToInt32(Console.ReadLine());
                    sum += numb;
                    count++;
                }
            }
            catch (Exception ex) 
            {
                if (count != 0) 
                {
                    result = (double) sum / count;
                    Console.WriteLine(result);
                }
                else 
                {
                    Console.WriteLine("Вы не ввели некорректные данные !!");
                    Main();
                
                }

            
            }



            

        }


    }
}