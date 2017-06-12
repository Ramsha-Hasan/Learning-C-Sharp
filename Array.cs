using System;
using System.Collections.Generic;

namespace c(sharp)
{
    class Program
    {
        static void Main(string[] args)
        {

                // 1D array

        int[] array = new int[2]; //uninitialized -- default value of element here is 0
        Console.WriteLine(array[0]);
        Console.WriteLine(array[1]);
       

        int[] array2 = new int[] { 1, 2, 3, 4, 5 }; // initialized
        Console.WriteLine(array2[1]);
        Console.WriteLine(array2[2]);
       

        int[] array3 = new [] { 6, 7, 8, 9 }; // type is inferred ----- new[] can also be omit
        Console.WriteLine(array3[2]);
   


                    //multi dimensional array

        int[,] multiarray = new int[2,2];  // [rows][columns]
        Console.WriteLine(multiarray[0,0]); 
        Console.WriteLine(multiarray[1,1]); 

        int[,] multiarray2 = { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9 } }; //[3][3]
        Console.WriteLine(multiarray2[0,2]); 
        Console.WriteLine(multiarray2[1,1]);
        Console.WriteLine(multiarray2[2,0]);


                    //jagged array - in this each element is an array itself
        
        int[][] jaggedArray = new int[4][]; // define first dimension -- 4 rows
        
        jaggedArray[1] = new int[4] { 11, 22, 33, 44 }; // set values of first array
        Console.WriteLine(jaggedArray[1][2]); // third element in first row
        Console.WriteLine(jaggedArray[1][3]); 

      //  Console.WriteLine(jaggedArray[2][2]); // value is null because further rows are not initialized


                    //string array with split  & join method

        string arrayOfName = "sharique.ramsha.ushna.reeba";
       
        string[] name = arrayOfName.Split('.');
        Console.WriteLine(name[0]); //sharique
        
        
        string combineArray = string.Join(" | ", name);
        Console.WriteLine(combineArray);

        List<int> emptyList = new List<int>(); // declares an empty list
        emptyList.Add(10);  // the list now has one item in it: {10}
        Console.WriteLine(emptyList[0]);


                        //Array with List (remove, insert, remove all, remove at, clear, count,)

        List<int> integers = new List<int>() { 2, 3, 4 }; 
        Console.WriteLine(integers[0]);

        string[] colors = "red,blue,yellow,green".Split(','); 
        Console.WriteLine(colors[2]);
        List<string> colorList = new List<string>(colors); 
        Console.WriteLine(colorList[0]);


        List<string> colorsArray = new List<string>() { "black", "white", "gray", "red", "blue", "brown", "gold", "pink" };
        colorsArray.Remove("black");
        colorsArray.Insert(0, "purple"); 
        Console.WriteLine($"colorsArray[0] {colorsArray[0]}");

        colorsArray.RemoveAll(c => c.Contains("e")); // removes all elements containing 'e'
        foreach (string element in colorsArray)
        Console.WriteLine(element); // display all elements of list
        Console.WriteLine($"colorsArray[0] {colorsArray[0]}");

        colorsArray.RemoveAt(0); 
        Console.WriteLine($"remove at ) so next elemnt is: {colorsArray[0]}");

        int numColors = colorsArray.Count; 
        Console.WriteLine($"Color present in list are now: {numColors}");

        colorsArray.Clear(); // empty list
        Console.WriteLine($"color present in list are now:  {colorsArray.Count}");
         
        }
    }
}
