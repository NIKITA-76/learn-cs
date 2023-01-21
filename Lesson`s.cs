namespace Lessons
{
	internal class Gen_arith
	{
		static void Main()
		{

			string choose;
			Console.WriteLine("Выберите операцию");
			Console.WriteLine("1 - gen_arith \n" +
				"2 - sum_and_times \n" +
				"3 - Конвертер валют");
			choose = Console.ReadLine();

			switch (choose)
			{
				case "1":
					gen_arith();
					break;

				case "2":
					sum_and_times();
					break;

				case "3":
					converter();
					break;

				default:
					Main();
					break;
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


		static void converter()
		{
			int dollar = 75;
			int euro = 85;
			int uan = 25;

			int result;

			Console.WriteLine("Выберети валюту\n" +
				"1 - Доллар\n" +
				"2 - Евро\n" +
				"3 - Юань");

			string choose = Console.ReadLine();

			switch (choose)
			{
				case "1":
					Console.WriteLine("Введите скол-во ваших долларов. Перевод будет по курсу ---> 75 за 1 Доллар");
					result = Convert.ToInt32(Console.ReadLine()) * dollar;
					Console.WriteLine("Результат: " + result);
					break;
				case "2":
					Console.WriteLine("Введите скол-во ваших долларов. Перевод будет по курсу ---> 85 за 1 Евро");
					result = Convert.ToInt32(Console.ReadLine()) * euro;
					Console.WriteLine("Результат: " + result);
					break;
				case "3":
					Console.WriteLine("Введите скол-во ваших долларов. Перевод будет по курсу ---> 25 за 1 Юань");
					result = Convert.ToInt32(Console.ReadLine()) * uan;
					Console.WriteLine("Результат: " + result);
					break;

				default:
					Console.WriteLine("Вы не выбрали валюту");
					converter();
					break;
			}



		}
	}
}