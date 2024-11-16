using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
	static public class ArrayMethods
	{
		//Counting Occurrences Array special Number
		static public int GetOccuerence(int[] arr, int number)
		{
			int count = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == number)
				{
					count++;
				}
			}
			return count;
		}

		//Reverse Array
		static public void ReverseArray(ref int[] arr)
		{
			int size = arr.Length;
			int[] newArr = new int[size];

			for (int i = 0, j = size - 1 ; i < arr.Length && j>= 0; i++,j--)
			{
				//Console.WriteLine($"i:{i}, j:{j}");
				newArr[j] = arr[i];
            }
			arr = newArr;
		}
		static public bool ItemInArray(List<int> arr, int item)
		{
			for(int i = 0; i < arr.Count; i++)
			{
				if (arr[i]== item)
				{ 
					return true;
				}
			}
			return false;
		}
		
		//Removing Duplicates
		static public void RemoveDuplication(ref int[] arr)
		{
			int size = arr.Length;
			List<int> newArr = new List<int>();

			//int index = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				
				if (!ItemInArray(newArr, arr[i]))
				{
					//newArr[index] = arr[i];
					//index++;
					newArr.Add(arr[i]);
				}
			}
			arr = newArr.ToArray();
		}
		
		
		//Function take array and search about specific Value "Linear Search"
		static public void SearchSpecificValue(int[] arr, int searchValue)
		{
			int value = 0;
			int index = -1;
			for(int i=0; i<arr.Length;i++)
			{
				if (arr[i]== searchValue)
				{
					value = arr[i];
					index = i;
					break;
				}
			}
            Console.WriteLine($"Vlue: {value} at Index {index}");
        }

		//Function Take array and return Second Largest Element
		static public int SecodLargestElement(int[] arr)
		{
			int largestElement = arr[0], secondLargestElement = 0;
			for(int i = 0; i<arr.Length;i++)
			{
				if (arr[i] > largestElement)
				{
					secondLargestElement = largestElement;
					largestElement = arr[i];
				}
			}
			return secondLargestElement;

		}


		//"Function Take Array ,and order type assending or desecnding
		//and return sorted array according sorted type"
		static public void SortArray(int[] arr,string typeOfSort)
		{
			if (typeOfSort == "asc")
			{
				for (int i = 0; i < arr.Length - 1; i++)
				{
					for (int j = 0; j < arr.Length - i - 1; j++)
					{
						if (arr[j] > arr[j + 1])
						{
							int temp = arr[j];
							arr[j] = arr[j + 1];
							arr[j + 1] = temp;
						}
					}
				}

			}
			else if(typeOfSort == "dis")
			{
				for (int i = 0; i < arr.Length - 1; i++)
				{
					for (int j = 0; j < arr.Length - i - 1; j++)
					{
						if (arr[j] < arr[j + 1])
						{
							int temp = arr[j];
							arr[j] = arr[j + 1];
							arr[j + 1] = temp;
						}
					}
				}

			}

		}

		static public void Display(int[] arr)
		{
			Console.Write("{");
			foreach (int item in arr)
			{
                Console.Write($" {item},");
            }
			Console.Write("}\n");

		}

	}
}
