﻿using System;

namespace LambdaSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Function function = new Function();
                function.FunctionHandler("test", null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
