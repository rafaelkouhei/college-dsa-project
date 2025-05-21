using System;

namespace MyProgram {
	public class MyClass{

		// Data Structures
		public class MyVector{
			public int[] Structure;
			public int Capacity;
			public int Size;

			public MyVector(int capacity){
				this.Structure = new int[capacity];
				this.Capacity = capacity;
			}
		}

		public class MyMatrix {

		}

		public class MyList {

		}

		public class MyQueue {

		}

		public class MyStack {

		}

		public static void callStack(){

		}

		// Search Algorithms
		public static int MyLinearSearch(int[] arr, int x){
			for(int i = 0; i < arr.Length; i++){
				if(arr[i] == x){
					return i;
				}
			}

			return -1;
		}

		public static int MyBinarySearch(int[] arr, int x){
			int lowest = 0, highest = arr.Length - 1;

			while(lowest <= highest){
				int middle = lowest + (highest - lowest) / 2;

				if(arr[middle] == x){
					return middle;
				}
				if(arr[middle] < x){
					lowest = middle + 1;
				} else {
					highest = middle - 1;
				}
			}

			return -1;
		}

		public static void Main(){
			Console.WriteLine("Welcome to My Interactive Console!");

			string optionChar = "";
			int optionInt = 0;

			Console.WriteLine("\nWhich Data Structure do you want to work with?:\n");
			Console.WriteLine("1. Vector\n2. Matrix\n3. List\n4. Queue\n5. Stack\n6. Leave program");

			while(optionInt == 0){
				optionChar = Console.ReadLine()!;

				try{
					optionInt = int.Parse(optionChar);
				} catch {
					Console.WriteLine("\nPlease, insert only numeric values...");
					continue;
				}

				switch(optionInt){
					case 1:
						break;
					case 2:
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						Console.WriteLine("\nSee you next time!\n");
						break;
					default:
						Console.WriteLine("\nPlease, insert a valid number...");
						optionInt = 0;
						break;
				}
			}
		}
	}
}