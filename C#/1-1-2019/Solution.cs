using System;
using System.Collections.Generic;

public class Solution {
	public static void Main(string[] args)
	{
		List<int> l = new List<int>() {
			0, 1, 2, 6, 7, 8, 9, 10, 12, 14, 15, 17, 18, 20
		};
		int n = 8;

		for (int i = 0; i < 10; i++) {
			Console.WriteLine(RandomNumber(n, l));
		}
	}

	/*
 * Given an integer n and a list of integers l,
 write a function that randomly generates a 
 number from 0 to n-1 that isn't in l (uniform).
 */
	private int RandomNumber(int n, List<int> l)
	{
		//Check to make sure L does have an open number in the range
		//TODO

		Random rand = new Random();

		//From here I think that finding a more efficient way of extracting random numbers
		//would be the best approach. I've done so one by one, and by random index so far.
		//TODO


		//Slight improvement on brute force
		//O(n) runtime (slightly improved), improvement on space
		int notCount = (n - 1) - l.Count;
		//Use a random index to represent the index of the random number not in l that we want
		int randIdx = rand.Next(0, notCount);
		for (int i = 0; i <= n - 1; i++) {
			if (!l.Contains(i)) {
				//Update randIdx
				randIdx--;
				if (randIdx < 0) {
					return i;
				}
			}
		}

		//Pick a random number, check
		//Could potentially be horrible in runtime depending on circumstances
		//TODO

		//Brute force, no considerations
		//This is O(n) complexity, O(2n) => O(n) space (Might be O(n) space)
		List<int> notInList = new List<int>();
		for(int i = 0; i <= n-1; i++) {
			if (!l.Contains(i)) {
				notInList.Add(i);
			}
		}

		
		return notInList[rand.Next(0, notInList.Count - 1)];
	}
}
