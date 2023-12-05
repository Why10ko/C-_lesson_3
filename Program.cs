namespace Task_1

// Задача 1 -------------------------------------------

// {
// 	public class Program
// 	{
// 		public static void Main(string [] arg) 
// 		{
// 			Random rand = new Random();
// 			int size = 10;			
// 			int [] array = new int[size];
// 			int total = 0;

// 			for (int i = 0; i < size; i++) 
// 			{
// 				array[i] = rand.Next(0,100);
// 				if (array[i] > 19 && array[i] < 91) 
// 				{
// 					total++;
// 				}
// 			}

// 			foreach (int item in array) 
// 			{
// 				System.Console.Write(item + " ");
// 			}		

// 			System.Console.WriteLine($"There are {total} numbers in total less than 90 and more then 19 ");
// 		}
// 	}
// }

// Задача 2 -------------------------------------------

{
	public class Program
	{
		public static void Main(string [] arg) 
		{
			Random rand = new Random();
			int size = 10;			
			int [] array = new int[size];
			int total = 0;

			for (int i = 0; i < size; i++) 
			{
				array[i] = rand.Next(0,100);
				if (array[i] % 2 == 0) 
				{
					total++;
				}
			}

			foreach (int item in array) 
			{
				System.Console.Write(item + " ");
			}		

			System.Console.WriteLine($"There are {total} even numbers in the array ");
		}
	}
}

// Задача 3 -------------------------------------------
// Задача 4 -------------------------------------------