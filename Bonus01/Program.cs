using System;
using System.Collections.Generic;

namespace Bonus01 {
	class Program {
		static void Main(string[] args) {
			//Part 1 - Setup
			//Tell the user what's happening/what we need from them, and capture the input to send to the method
			Console.WriteLine("Please enter a string of numbers seperated by commas (,). This program will return the sun and average of those numbers ");
			SplitValidateAndComputeInput(Console.ReadLine()); //Send the single string to the new method
		}

		static bool SplitValidateAndComputeInput(string stringIn) {
			if (stringIn.Length == 0) return false;

			//Part 2 - Data grooming and validation
			string[] splitString = stringIn.Split(","); //Turn our input string into an array of strings
			List<Int32> intsToWorkWith = new List<Int32>(); //And get a list of ints ready to hold them

			foreach (string s in splitString) {
				try {
					int i = Int32.Parse(s);
					intsToWorkWith.Add(i);
				}
				catch {
					//Scold the user for bad input, GIGO people.... GIGO
					Console.WriteLine($"There was an error converting: {s}");
					Console.WriteLine("Aborting.");
					return false; //We'll return false if we encounter an error to stop the program dead in it's tracks
				}
			}

			//Part 3 - Data magic!
			int sumOfInts = 0;
			foreach (int i in intsToWorkWith) {
				sumOfInts += i; //Get our sum
			}
			double avgOfInts = (double) sumOfInts / (double) intsToWorkWith.Count; //Get our average as a double since not all averages will be interger
			Console.WriteLine($"Sum: {sumOfInts} | Avg: {avgOfInts:N2}");
			Console.WriteLine("Thank you and have a great day! =]");

			return true;
		}
	}
}
