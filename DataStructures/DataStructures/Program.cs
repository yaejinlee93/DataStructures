using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dongyeon ha
namespace DataStructuresAssignment
{
    class Program
        //jjj
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            string userWordInput = " ";

            Stack<string> myStack = new Stack<string>();
            Queue<string> myQueue = new Queue<string>();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            do
            {
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("Please Select one. (1-4)");
                Console.WriteLine();

                Console.WriteLine("1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dictionary");
                Console.WriteLine("4. Exit");

                Console.WriteLine();
                Console.Write("Enter selection: ");

                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("STACK");
                        Console.WriteLine("Please Select one. (1-7)");
                        Console.WriteLine();

                        Console.WriteLine("1. Add one time to Stack");
                        Console.WriteLine("2. Add Huge List of Items to Stack");
                        Console.WriteLine("3. Display Stack");
                        Console.WriteLine("4. Delete from Stack");
                        Console.WriteLine("5. Clear Stack");
                        Console.WriteLine("6. Search Stack");
                        Console.WriteLine("7. Return to Main Menu");

                        Console.WriteLine();
                        Console.Write("Enter selection: ");

                        userInput = Convert.ToInt32(Console.ReadLine());

                        switch (userInput)
                        {
                            case 1:

                                Console.WriteLine();
                                Console.Write("Enter a word: ");

                                userWordInput = Console.ReadLine();

                                myStack.Push(userWordInput);

                                Console.WriteLine();
                                Console.WriteLine(myStack.Peek() + " is added sucessfully.");

                                break;
                            case 2:

                                myStack.Clear();

                                for (int iCount = 1; iCount < 2001; iCount++)
                                {
                                    myStack.Push("New Entry " + iCount);

                                }

                                Console.WriteLine();
                                Console.WriteLine("2000 items successfully added.");

                                break;
                            case 3:

                                if (myStack.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Stack is Empty.");
                                }
                                else
                                {
                                    Console.WriteLine();

                                    foreach (string item in myStack)
                                    {
                                        Console.WriteLine(item);
                                    }
                                }

                                break;
                            case 4:

                                if (myStack.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Stack is Empty.");
                                }
                                else
                                {
                                    Stack<string> holdStack = new Stack<string>();

                                    int itemNum = myStack.Count();

                                    Console.WriteLine();
                                    Console.Write("Which item do you want to delete? ");

                                    userWordInput = Console.ReadLine();

                                    for (int iCount = 0; iCount < itemNum; iCount++)
                                    {
                                        if (myStack.Peek() == userWordInput)
                                        {
                                            myStack.Pop();
                                            Console.WriteLine();
                                            Console.WriteLine("Item \"" + userWordInput + "\" deleted.");
                                        }
                                        else
                                        {
                                            holdStack.Push(myStack.Pop());
                                        }
                                    }

                                    for (int iCount = 0; iCount < itemNum - 1; iCount++)
                                    {
                                        myStack.Push(holdStack.Pop());
                                    }
                                }

                                break;
                            case 5:

                                if (myStack.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Stack is Empty.");
                                }
                                else
                                {
                                    myStack.Clear();

                                    Console.WriteLine();
                                    Console.WriteLine("Cleared!");
                                }

                                break;
                            case 6:

                                if (myStack.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Stack is Empty.");
                                }
                                else
                                {
                                    Stack<string> holdStack = new Stack<string>();

                                    int itemNum = myStack.Count();
                                    bool flag = false;

                                    Console.WriteLine();
                                    Console.Write("Which item do you want to search? ");

                                    userWordInput = Console.ReadLine();

                                    sw.Start();

                                    for (int iCount = 0; iCount < itemNum; iCount++)
                                    {
                                        if (myStack.Peek() == userWordInput)
                                        {
                                            sw.Stop();

                                            Console.WriteLine();
                                            Console.WriteLine("Item FOUND!");
                                            Console.WriteLine("Run Time: " + sw.Elapsed);

                                            holdStack.Push(myStack.Pop());

                                            flag = true;
                                        }
                                        else
                                        {
                                            holdStack.Push(myStack.Pop());
                                        }
                                    }

                                    if (flag == false)
                                    {
                                        sw.Stop();

                                        Console.WriteLine();
                                        Console.WriteLine("Item NOT FOUND!");
                                    }

                                    for (int iCount = 0; iCount < itemNum; iCount++)
                                    {
                                        myStack.Push(holdStack.Pop());
                                    }

                                    sw.Reset();

                                }

                                break;
                            default:
                                Console.WriteLine();
                                break;
                        }

                    } while (userInput != 7);
                }
                else if (userInput == 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("QUEUE");
                        Console.WriteLine("Please Select one. (1-7)");
                        Console.WriteLine();

                        Console.WriteLine("1. Add one time to Queue");
                        Console.WriteLine("2. Add Huge List of Items to Queue");
                        Console.WriteLine("3. Display Queue");
                        Console.WriteLine("4. Delete from Queue");
                        Console.WriteLine("5. Clear Queue");
                        Console.WriteLine("6. Search Queue");
                        Console.WriteLine("7. Return to Main Menu");

                        Console.WriteLine();
                        Console.Write("Enter selection: ");
                        Console.WriteLine();

                        userInput = Convert.ToInt32(Console.ReadLine());

                        switch (userInput)
                        {
                            case 1:

                                Console.WriteLine();
                                Console.Write("Enter a word: ");

                                userWordInput = Console.ReadLine();

                                myQueue.Enqueue(userWordInput);

                                Console.WriteLine();
                                Console.WriteLine(myQueue.Peek() + " is added sucessfully.");

                                break;
                            case 2:

                                myQueue.Clear();

                                for (int iCount = 1; iCount < 2001; iCount++)
                                {
                                    myQueue.Enqueue("New Entry " + iCount);

                                }

                                Console.WriteLine();
                                Console.WriteLine("2000 items successfully added.");

                                break;
                            case 3:

                                if (myQueue.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Queue is Empty.");
                                }
                                else
                                {
                                    Console.WriteLine();

                                    foreach (string item in myQueue)
                                    {
                                        Console.WriteLine(item);
                                    }
                                }

                                break;
                            case 4:

                                if (myQueue.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Queue is Empty.");
                                }
                                else
                                {
                                    Queue<string> holdQueue = new Queue<string>();

                                    int itemNum = myQueue.Count();

                                    Console.WriteLine();
                                    Console.Write("Which item do you want to delete? ");

                                    userWordInput = Console.ReadLine();

                                    for (int iCount = 0; iCount < itemNum; iCount++)
                                    {
                                        if (myQueue.Peek() == userWordInput)
                                        {
                                            myQueue.Dequeue();
                                            Console.WriteLine();
                                            Console.WriteLine("Item \"" + userWordInput + "\" deleted.");
                                        }
                                        else
                                        {
                                            holdQueue.Enqueue(myQueue.Dequeue());
                                        }
                                    }

                                    for (int iCount = 0; iCount < itemNum - 1; iCount++)
                                    {
                                        myQueue.Enqueue(holdQueue.Dequeue());
                                    }
                                }

                                break;
                            case 5:

                                if (myQueue.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Queue is Empty.");
                                }
                                else
                                {
                                    myQueue.Clear();

                                    Console.WriteLine();
                                    Console.WriteLine("Cleared!");
                                }

                                break;
                            case 6:

                                bool flag = false;

                                if (myQueue.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Queue is Empty.");
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.Write("Which item do you want to search? ");

                                    userWordInput = Console.ReadLine();

                                    sw.Start();

                                    foreach (string item in myQueue)
                                    {
                                        if (item == userWordInput)
                                        {
                                            sw.Stop();

                                            Console.WriteLine();
                                            Console.WriteLine("Item FOUND!");
                                            Console.WriteLine("Run Time: " + sw.Elapsed);

                                            flag = true;

                                        }
                                    }

                                    if (flag == false)
                                    {
                                        sw.Stop();

                                        Console.WriteLine();
                                        Console.WriteLine("Item NOT FOUND!");

                                    }

                                    sw.Reset();
                                }
                                break;
                            default:
                                Console.WriteLine();
                                break;

                        }

                    } while (userInput != 7);
                }
                else if (userInput == 3)
                {
                    int countKey = 1;

                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("DICTIONARY");
                        Console.WriteLine("Please Select one. (1-7)");
                        Console.WriteLine();

                        Console.WriteLine("1. Add one time to Dictionary");
                        Console.WriteLine("2. Add Huge List of Items to Dictionary");
                        Console.WriteLine("3. Display Dictionary");
                        Console.WriteLine("4. Delete from Dictionary");
                        Console.WriteLine("5. Clear Dictionary");
                        Console.WriteLine("6. Search Dictionary");
                        Console.WriteLine("7. Return to Main Menu");

                        Console.WriteLine();
                        Console.Write("Enter selection: ");
                        Console.WriteLine();

                        userInput = Convert.ToInt32(Console.ReadLine());

                        switch (userInput)
                        {
                            case 1:
                                if (myDictionary.ContainsKey(" ") == false)
                                {
                                    Console.Write("Enter a word: ");

                                    userWordInput = Console.ReadLine();

                                    myDictionary.Add(userWordInput, countKey);

                                    Console.WriteLine();
                                    Console.WriteLine(userWordInput + " is added sucessfully.");

                                    countKey++;
                                }
                                break;

                            case 2:
                                myDictionary.Clear();

                                for (int iCount = 1; iCount < 2001; iCount++)
                                {
                                    myDictionary.Add("New Entry " + iCount, iCount);
                                }

                                Console.WriteLine();
                                Console.WriteLine("2000 items are successfully added.");

                                break;

                            case 3:
                                if (myDictionary.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("The Dictionary is Empty.");
                                }
                                else
                                {
                                    Console.WriteLine();
                                    foreach (KeyValuePair<string, int> DictItem in myDictionary)
                                    {
                                        Console.WriteLine("Key: " + DictItem.Key + " Value: " + DictItem.Value);
                                    }
                                }
                                break;

                            case 4:
                                if (myDictionary.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("The Dictionary is Empty.");
                                }
                                else
                                {
                                    Console.Write("Which item do you want to delete? ");

                                    userWordInput = Console.ReadLine();

                                    if (myDictionary.ContainsKey(userWordInput))
                                    {
                                        myDictionary.Remove(userWordInput);

                                        Console.WriteLine();
                                        Console.WriteLine("Item deleted.");
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("There is no \"" + userWordInput + "\" item to delete.");
                                    }
                                }
                                break;

                            case 5:
                                if (myDictionary.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("The Dictionary is Empty.");
                                }
                                else
                                {
                                    myDictionary.Clear();

                                    Console.WriteLine();
                                    Console.WriteLine("It is all cleared!");
                                }
                                break;

                            case 6:
                                if (myDictionary.Count() == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("The Dictionary is Empty.");
                                }
                                else
                                {
                                    Console.Write("Which item do you want to search? ");

                                    userWordInput = Console.ReadLine();

                                    if (myDictionary.ContainsKey(userWordInput) == false)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("NOT FOUND!");
                                    }
                                    sw.Start();

                                    foreach (KeyValuePair<string, int> DictItem in myDictionary)
                                    {
                                        if (DictItem.Key == userWordInput)
                                        {
                                            sw.Stop();

                                            Console.WriteLine();
                                            Console.WriteLine("FOUND!");
                                            Console.WriteLine("Key: " + DictItem.Key + " Value: " + DictItem.Value);
                                            Console.WriteLine("Run Time: " + sw.Elapsed);

                                            sw.Reset();
                                        }
                                    }
                                }
                                break;

                            default:
                                Console.WriteLine();
                                break;
                        }

                    } while (userInput != 7);
                }

            } while (userInput != 4);

            //Console.ReadKey();
        }
    }
}

//The End
