using System;
using System.Collections.Generic;
/*
This problem was asked Microsoft.

Using a read7() method that returns 7 characters from a file,
implement readN(n) which reads n characters.

For example, given a file with the content “Hello world”,
three read7() returns “Hello w”, “orld” and then “”.
*/
public class Solution {
	//Setting input this way to maintain accuracy with the question
	//where read7() has no arguments
	static string input;

	public static void Main(string[] args) {
		if (args.Length != 2) {
			Console.WriteLine("You need to pass two arguments!\nUsage: [input] [n]");
			return;
		}
		input = args[0];
		int n = int.Parse(args[1]);
		Console.WriteLine(readN(n));
	}

	public static string readN(int n)
	{
		//While input has 7 characters available, take 7 at a time
		string output = "";
		for (int i = 0; i < n / 7; i++) {
			output += read7();
		}
		//Take the remaining characters
		if (n % 7 > 0 && input.Length > 0) {
			output += input.Substring(0, Math.Min(input.Length, n % 7));
		}
		return output;
	}

	/// <summary>
	/// Returns the next 7 characters in a string while clipping the string
	/// </summary>
	/// <param name="input">The input string</param>
	/// <returns>The first 7 characters</returns>
	public static string read7()
	{
		if (input.Length == 0) return "";

		string clip;
		if (input.Length >= 7) {
			clip = input.Remove(7);
			input = input.Substring(7);
		} else {
			clip = input;
			input = "";
		}
		return clip;
	}
}
