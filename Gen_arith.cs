

namespace Lessons // Note: actual namespace depends on the project name.
{
    internal class Gen_arith
    {
        static void Main()
        {

            string choose;
            Console.WriteLine("Выберите операцию");
            Console.WriteLine("1 - gen_arith");
            Console.WriteLine("2 - sum_and_times");
            choose = Console.ReadLine();
            if (choose == "1")
            {
                gen_arith();
            }
            else if(choose == "2")
            {
                sum_and_times();
            }
            else
            {
                Main();
            }

            

        }

        static void sum_and_times()
        {
                var list_of_num = new List<int>();
                int accum = 0;
                int sum = 0;
                int sum_t = 1;
                Console.WriteLine("Введите числа для обработки через Enter. После завершения ввода чисел, нажмите Enter");

                try
                {
                    while (true)
                    {
                        accum++;
                        list_of_num.Add(Convert.ToInt32(Console.ReadLine()));


                        sum++;
                    }
                }
                catch
                {
                    foreach (int i in list_of_num)
                    {

                        sum += i;
                        sum_t *= i;

                    }
                    Console.WriteLine("Сумма всех чисел --- > " + sum);
                    Console.WriteLine("Произведение всех чисел --- > " + sum_t);

                }

        }



        static void gen_arith()
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
                    result = (double)sum / count;
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