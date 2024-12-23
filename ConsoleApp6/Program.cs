using System.ComponentModel;
using static System.Formats.Asn1.AsnWriter;
using System.Drawing;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        #region . 1Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
        //Console.Write("Enter the size of the matrix ");
        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        if (i == j)
        //            Console.Write("1 ");
        //        else
        //            Console.Write("0 ");
        //    }
        //}
        #endregion
        //#region 2Write a program in C# Sharp to find the sum of all elements of the array.
        //Console.WriteLine("enter size of array:");
        //    int size=int.Parse(Console.ReadLine());
        //int[]array=new int[size];
        //for(int i=0; i<size; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        //int sum = 0;
        //for(int i=0;i<size ; i++)
        //{
        //    sum += array[i];
        //}
        //Console.WriteLine(sum);
        //#endregion
        //#region 3- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
        //Console.Write("Enter the size ");
        //int size = int.Parse(Console.ReadLine());
        //int[] array1 = new int[size];
        //int[] array2 = new int[size];

        //Console.WriteLine("Enter elements of first array:");
        //for (int i = 0; i < size; i++)
        //{
        //    array1[i] = int.Parse(Console.ReadLine());
        //}

        //Console.WriteLine("Enter elements of second array:");
        //for (int i = 0; i < size; i++)
        //{
        //    array2[i] = int.Parse(Console.ReadLine());
        //}

        //int[] array3 = array1.Concat(array2).ToArray();
        //Array.Sort(array3);
        //foreach(var item in array3)
        //{
        //    Console.WriteLine(item);
        //}
        //#endregion
        //    #region 5- Write a program in C# Sharp to find maximum and minimum element in an array
        //    Console.WriteLine("enter the size of array:");
        //    int size=int.Parse(Console.ReadLine());
        //    int[]array = new int[size];
        //    for(int i = 0; i < size; i++)
        //    {
        //        array[i] = int.Parse(Console.ReadLine());

        //    }
        //    int max = array[0];
        //    int min = array[0];
        //    for(int i = 0; i < size;i++)
        //    {
        //        if(array[i] > max )
        //            max = array[i];
        //        if (array[i] < min )    min = array[i];
        //    }
        //    Console.WriteLine(max);
        //    Console.WriteLine(min);
        ////    #endregion
        //#region  6-Write a program in C# Sharp to find the second largest element in an array.
        //Console.WriteLine("enter the size of array:");
        //int size = int.Parse(Console.ReadLine());
        //int[] array = new int[size];
        //for (int i = 0; i < size; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());

        //}
        //Array.Sort(array);
        //int seclarge = array[size - 2];
        //Console.WriteLine(seclarge);
        //#endregion
        //#region 9-Given a list of space separated words, reverse the order of the words.

        //Console.WriteLine("Enter a string:");
        //    string input = Console.ReadLine();
        //    string[] word = input.Split(' ');
        //    Array.Reverse(word);
        //Console.WriteLine(string.Join(" ", word));
        //#endregion
        //#region 10) Write a program to create two multidimensional arrays of same size.Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
        //Console.Write("Enter rows: ");
        //int rows = int.Parse(Console.ReadLine());
        //Console.Write("Enter columns: ");
        //int cols = int.Parse(Console.ReadLine());

        //int[,] array1 = new int[rows, cols];
        //int[,] array2 = new int[rows, cols];

        //Console.WriteLine("Enter elements ");
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        array1[i, j] = int.Parse(Console.ReadLine());
        //        array2[i, j] = array1[i, j];
        //    }
        //}
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write(array2[i, j] );
        //    }
        //}
        //#endregion
        //#region 11-write a Program to Print One Dimensional Array in Reverse Order
        //Console.WriteLine("enter size of array:");
        //int size = int.Parse(Console.ReadLine());
        //int[] array = new int[size];
        //Console.WriteLine("enter elements");
        //for (int i = 0; i < size; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        //Array.Reverse(array);
        //foreach (var item in array) { 
        //Console.WriteLine(item); }
        //#endregion

    }
}

