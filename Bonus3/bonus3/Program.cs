namespace bonus3
{
	internal class Program
	{
		static void Main(string[] args) {
			/* Bonus 3
			 * Kris Oud - 301274712
			 * */

			string fileName = "";
			Console.WriteLine("Bonus Assignment 3 - Kris Oud\n");

			//1 - The user should be prompted to enter the filename of the file containing the list of numbers.
			Console.Write("Please enter the filename: ");
			fileName = Console.ReadLine();

			//5 - If the file does not exist or cannot be read, the program should catch the exception and display an
			//    appropriate error message to the user.
			if (File.Exists(fileName)) {
				ParseFile(fileName); //We only proceed if the file exists
			} else {
				Console.WriteLine("Error: File not found");
			}
		}

		//2 - The program should read the file and extract the list of numbers.
		public static void ParseFile(string fileName) {
			List<int> numbersList = new List<int>();
			string? curLine;
			int sumOfNumbers = 0;
			using (TextReader reader = new StreamReader(fileName)) { //We'll use a 'using' to ensure the resources are properly disposed of
				//9 - The program should use try-catch-finally blocks to ensure that any resources are
				//    cleaned up correctly, regardless of whether an exception was thrown.
				try {
					while ((curLine = reader.ReadLine()) != null) {
						int curInt = Int32.Parse(curLine);
						numbersList.Add(curInt);
					}

					//7 - If the list of numbers is empty, the program should catch the
					//    exception and display an appropriate error message to the user.
					if (numbersList.Count > 0) {
						foreach (int n in numbersList) {
							sumOfNumbers += n;
						}
						//3 - The program should compute the average of the list of numbers.
						Console.WriteLine($"The average is: {((double)sumOfNumbers / (double)numbersList.Count):F3}");
					}
					else {
						Console.WriteLine("The list of numbers is empty; cannot proceed. Terminating Program.");
					}
				}
				//6 - If any of the lines in the file do not contain a valid number, the program should catch
				//    the exception and display an appropriate error message to the user.
				catch (FormatException fe) {
					Console.WriteLine(fe.Message);
					//4 - If an exception occurs during file reading or during the calculation of the average, the program
					//    should catch it and display an appropriate error message to the user.
				}
				catch (Exception ex) {
					Console.WriteLine(ex.Message);
				}
				finally {
					if (reader != null) {
						reader.Close();
						reader.Dispose();
					}
				}
			}
		}
	}
}