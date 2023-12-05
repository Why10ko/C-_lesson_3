namespace Task_1

// Задача 1 -------------------------------------------

{
	public class Program
	{
		public static void Main(string [] arg) 
		{
			Random rand = new Random();
			int size = 10;			
			int [] array = new int[size];

			for (int i = 0; i < size; i++) 
			{
				array[i] = rand.Next(0,100);
			}

			foreach (int item in array) 
			{
				System.Console.Write(item + " ");
			}			
		}
	}
}

// Задача 2 -------------------------------------------
// Задача 3 -------------------------------------------
// Задача 4 -------------------------------------------