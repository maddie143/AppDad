using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDad
{
    class Months
    {

        public static string[] months = {"Ianuarie","Februarie","Martie","Aprilie","Mai","Iunie","Iulie","August","Septembrie","Octombrie","Noiembrie","Decembrie"};
        public static int[] days      = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public static int[,] conss = { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }};
        //public static string[] errors = new string[13] { };
        public static List<string> error = new List<string>();

        public static void delete_list()
        {
            error.Clear();
        }
    }
}
