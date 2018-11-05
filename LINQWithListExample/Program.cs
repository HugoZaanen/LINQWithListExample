using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWithListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //popluate a List of strings
            var items = new List<string>();
            items.Add("aQua");//add "aQua" to the end of the list
            items.Add("RusT");//add "RusT" to the end of the list
            items.Add("yElLow");//add "yElLow" to the end of the list
            items.Add("rEd");//add "rEd" to the end of the list

            //display initial list
            Console.Write("items contains");
            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();//output end of line

            //convert to uppercase, select those starting with "R" and sort
            var startsWithR =
                from item in items
                let uppercaseString = item.ToUpper()
                where uppercaseString.StartsWith("R")
                orderby uppercaseString
                select uppercaseString;

            //display query results
            Console.Write("results of query startsWithR: ");
            foreach(var item in startsWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();//output end of line

            //display updated query results
            foreach(var item in startsWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();//output end of line
            Console.Read();
        }
    }
}
