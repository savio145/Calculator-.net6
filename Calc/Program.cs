using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Use of Collection for History Maintainance
            List<IOperations> OperationsHistory = new List<IOperations>();
            //Factory Class Object which returns be operation object
            OperationsFactory factory = new OperationsFactory();

            //input/output
            Console.WriteLine("Welcome to Calculator Interface With history Tracking");
            Console.WriteLine(">> You can Perform Plus, Minus, Multiply, Division and Power Operations using this Calculator") ;
            Console.WriteLine("Press any Key to Get Started");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------");
            bool exit = false;
            while (!exit)
            {
                int input;
                Console.WriteLine("Press 1 for Calculator");
                Console.WriteLine("Press 2 to View History");
                Console.WriteLine("Press 3 to Exit");
                input = Convert.ToInt32(Console.ReadLine());
                double num1, num2;
                char op;
                switch (input)
                {
                    //taking input for calculations
                    case 1:
                        try
                        {
                            Console.Write(">> Enter Number : ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write(">> Enter Operation (/,*,+,-,^) : ");
                            op = Convert.ToChar(Console.ReadLine());
                            
                            Console.Write(">> Enter Number : ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            //handling divided by 0 case
                            if(num2==0 && op=='/')
                            {
                                throw new DivideByZeroException();
                            }
                            else
                            {
                                //else calculating result by calling Factory Solve Method, 
                                //which automatically checks which operation to perform
                                //creates object of specified operation class , calculates result
                                //and returns object which contains Expression and Result both.
                                string expression = num1.ToString() + op.ToString() + num2.ToString();
                                var operation = factory.Solve(expression);
                                //if there is any operation other then /, *, + , - , ^
                                if(operation == null)
                                {
                                    Console.WriteLine(">> WE CAN'T PERFORM THIS OPERATION");
                                    continue;
                                }
                                else
                                {
                                    //adding operation object to List for history maintainance
                                    OperationsHistory.Add(operation);
                                    //printing result
                                    Console.WriteLine(operation);
                                }
                            }
                        }
                        //incase user enters invalid input as number or operator

                        catch(Exception ex)
                        {
                            Console.WriteLine(">> INVALID INPUT !! "+ex.Message);
                        }
                        break;
                    //printing History
                    case 2:
                        //printing history
                        Console.WriteLine("Calculations History !");
                        for(int i = 0; i < OperationsHistory.Count; i++)
                        {
                            Console.WriteLine(">> "+ OperationsHistory[i]);
                        }
                        break;
                    case 3:
                        //exit condition
                        exit = true;
                        break;
                    default:
                        Console.WriteLine(">> INVALID INPUT !!");
                        break;
                }
            }
        }
    }
}
