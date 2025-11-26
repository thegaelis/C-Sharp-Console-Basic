using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Array_String_Exception_Methods
{
    public class Program
    {
        const int MAX_INT = 999999999;
        const int MAX_CITY = 100;
        static void Main(string[] args)
        {

            //Assume that we need to solve Dijkstra shortest path. We need:
            //1 list to store city
            //1 matrix to adjacent matrix of integer (w=-1 for no connection, w>=0 for having connection, w is the weight of edge).
            //Declare array 1D of city, max 100 city

            //Don't: string[MAX_CITY] city;
            //Do: string[] city = new string[MAX_CITY];
            string[] city = new string[MAX_CITY];

            //Prompt to user enter list of city and end if user press 'F'.
            int numOfCity = 0;
            do
            {
                Console.WriteLine("Enter the city: ");
                city[numOfCity] = Console.ReadLine();
                numOfCity++;
                Console.WriteLine("Enter Y to continue or press any key to exit");
            }
            while (Console.ReadKey().Key == ConsoleKey.Y);


            //Declare array 2D of adjacent matrix
            //if we don't know the size
            //int[,] AdjacentMatrix;
            //if we have size in mind
            //in this case, a matix of n x n, with n is number of city

            //Get amount of city in the city array
            //Alternative: int numOfCity = city.GetLength(0) (GetLength(x), x is the dimension of array that needs to retrieve)
            //Assume that 2D array: int numOfCity1 = city.GetLength(0); int numOfCity2 = city.GetLength(1);

            //Print list of city
            for (int i = 0; i < numOfCity; i++)
            {
                Console.Write(city[i] + " ");
            }


            Console.WriteLine("Enter adjacent matrix weight");

            int[,] adjacentMatrix = new int[numOfCity,numOfCity];
            for (int i = 0; i<numOfCity-1; i++)
            {
                for (int j = 0;j<numOfCity; j++)
                {
                    Console.WriteLine($"{city[i]} and {city[j]}, value:");
                    adjacentMatrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            // Print the matrix

            // for (int i = 0; i<numOfCity; i++)
            // {
            //     for (int j = 0; i<numOfCity; j++)
            //     {
            //         Console.Write(adjacentMatrix[i,j]+ " ");
            //     }
            //     Console.WriteLine();
            // }

            printArray(adjacentMatrix);
            
            Console.Write("Select City:");
            int selectCity = int.Parse(Console.ReadLine());
            

            //Assign all value in the tableDijkstra to maxed value, except the start pos.
            int[,] tableDijkstra = new int[numOfCity,numOfCity];
            for (int i = 0; i<numOfCity; i++)
            {
                for (int j = 0; i<numOfCity; j++)
                {
                    tableDijkstra[i,j] = MAX_INT;
                }
            }
            //Assign weight to the start as 0
            tableDijkstra[selectCity,selectCity] = 0;
        }

        // What you can see in swapArrayElement<T>, <T> is for template
        // It is made so any kind of array variable can use this, apply for int array, string array, <List> array

        public static void swapArrayElement<T> (T[] array, int n1, int n2)
        {
            if (n1 < 0 || n1 >= array.Length || n2 < 0 || n2 >= array.Length)
            {
                throw new IndexOutOfRangeException("Indices are out of array bounds.");
            }
            
            T temp = array[n1];
            array[n1] = array[n2];
            array[n2] = temp;
        }

        // 2 method has same name
        // But the method different in input parameter (one is single dimension array, other is 2D array)
        // This is called compile-time polymorphism

        public static void printArray<T> (T[] array)
        {
            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void printArray<T> (T[,] array)
        {
            int sizeColumn = array.GetLength(0);
            int sizeRow = array.GetLength(1);
            for (int i = 0; i < sizeColumn; i++)
            {
                for (int j = 0; j < sizeRow; j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}