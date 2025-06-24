//using System.Collections.Generic;

//1.(A) Create an ArrayList for StudentName and perform following operations:
//    a.Add() - To Add new student in list
//    b.Remove() - To Remove Student with speci ed index
//    c. RemoveRange() - To Remove student with speci ed range.
//    d. Clear() - To clear all the student from the list using switch.
//using System.Collections;

//ArrayList studentNames = new ArrayList();
//bool exit = true;
//while (exit == true)
//{
//    Console.WriteLine("\nStudent Management System");
//    Console.WriteLine("1. Add Student");
//    Console.WriteLine("2. Remove Student by Index");
//    Console.WriteLine("3. Remove Range of Students");
//    Console.WriteLine("4. Clear All Students");
//    Console.WriteLine("5. Display Students");
//    Console.WriteLine("6. Exit");
//    Console.Write("Choose an option: ");

//    string choice = Console.ReadLine();

//    switch (choice)
//    {
//        case "1":
//            Console.Write("Enter Student Name: ");
//            string studentName = Console.ReadLine();
//            if (!string.IsNullOrEmpty(studentName))
//            {
//                studentNames.Add(studentName);
//                Console.WriteLine($"Added: {studentName}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid name.");
//            }
//            break;
//        case "2":
//            Console.Write("Enter index to remove: ");
//            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < studentNames.Count)
//            {
//                studentNames.RemoveAt(index);

//                Console.WriteLine($"Removed student at index {index}.");
//            }
//            else
//            {
//                Console.WriteLine("Invalid index.");
//            }
//            break;
//        case "3":
//            Console.Write("Enter start index to remove range: ");
//            if (int.TryParse(Console.ReadLine(), out int startIndex) && startIndex >= 0 && startIndex < studentNames.Count)
//            {
//                Console.Write("Enter count of students to remove: ");
//                if (int.TryParse(Console.ReadLine(), out int count) && count > 0 && startIndex + count <= studentNames.Count)
//                {
//                    studentNames.RemoveRange(startIndex, count);

//                    Console.WriteLine($"Removed {count} students starting from index {startIndex}.");
//                }
//                else
//                {
//                    Console.WriteLine("Invalid count.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid start index.");
//            }
//            break;
//        case "4":
//            studentNames.Clear();

//            Console.WriteLine("All students cleared.");
//            break;
//        case "5":
//            if (studentNames.Count > 0)
//            {
//                Console.WriteLine("Current Students:");
//                foreach (var name in studentNames)
//                {
//                    Console.WriteLine(name);
//                }
//            }
//            else
//            {
//                Console.WriteLine("No students in the list.");
//            }
//            break;
//        case "6":
//            exit = false;
//            Console.WriteLine("Exiting the program.");
//            break;
//    }
//}
//using System.Collections;
//using System.Collections.Generic;

//2.(A) Create a List for StudentName and perform following operations:
//    a.Add() - To Add new student in list
//    b.Remove() - To Remove Student with speci ed index
//    c. RemoveRange() - To Remove student with speci ed range.
//    d. Clear() - To clear all the student from the list
//List<string> studentNames = new List<string>();
//bool exit = true;
//while (exit)
//{
//    Console.WriteLine("\nStudent Management System");
//    Console.WriteLine("1. Add Student");
//    Console.WriteLine("2. Remove Student by Index");
//    Console.WriteLine("3. Remove Range of Students");
//    Console.WriteLine("4. Clear All Students");
//    Console.WriteLine("5. Display Students");
//    Console.WriteLine("6. Exit");
//    Console.Write("Choose an option: ");
//    string choice = Console.ReadLine();
//    switch (choice)
//    {
//        case "1":
//            Console.Write("Enter Student Name: ");
//            string studentName = Console.ReadLine();
//            if (!string.IsNullOrEmpty(studentName))
//            {
//                studentNames.Add(studentName);
//                Console.WriteLine($"Added: {studentName}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid name.");
//            }
//            break;
//        case "2":
//            Console.Write("Enter index to remove: ");
//            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < studentNames.Count)
//            {
//                studentNames.RemoveAt(index);
//                Console.WriteLine($"Removed student at index {index}.");
//            }
//            else
//            {
//                Console.WriteLine("Invalid index.");
//            }
//            break;
//        case "3":
//            Console.Write("Enter start index to remove range: ");
//            if (int.TryParse(Console.ReadLine(), out int startIndex) && startIndex >= 0 && startIndex < studentNames.Count)
//            {
//                Console.Write("Enter count of students to remove: ");
//                if (int.TryParse(Console.ReadLine(), out int count) && count > 0 && startIndex + count <= studentNames.Count)
//                {
//                    studentNames.RemoveRange(startIndex, count);
//                    Console.WriteLine($"Removed {count} students starting from index {startIndex}.");
//                }
//                else
//                {
//                    Console.WriteLine("Invalid count.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid start index.");
//            }
//            break;
//        case "4":
//            studentNames.Clear();
//            Console.WriteLine("All students cleared.");
//            break;
//        case "5":
//            if (studentNames.Count > 0)
//            {
//                Console.WriteLine("Current Students:");
//                foreach (var name in studentNames)
//                {
//                    Console.WriteLine(name);
//                }
//            }
//            else
//            {
//                Console.WriteLine("No students in the list");
//            }
//            break;
//        case "6":
//            exit = false;
//            Console.WriteLine("Exiting the program.");
//            break;
//        default:
//            Console.WriteLine("Invalid choice. Please try again.");
//            break;
//    }
//}.


//3.(B) Create a Stack which takes integer values and perform following operations:
//    a.Push() - To Add new item in stack
//    b.Pop() - To Remove item from the stack
//    c. Peek() – To Return the top item from the stack.
//    d. Contains() - To Checks whether an item exists in the stack or not.
//    e. Clear() - To clear items from stack
//using System;
//using System.Collections.Generic;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.Generic;
//using System.Collections;
//using System.Collections.Generic;
//using System;
//using System.Collections.Generic;
//using System.Collections;
//Stack<int> numberStack = new Stack<int>();
//bool exit = true;
//while (exit)
//{
//    Console.WriteLine("\nStack Management System");
//    Console.WriteLine("1. Push Item");
//    Console.WriteLine("2. Pop Item");
//    Console.WriteLine("3. Peek Item");
//    Console.WriteLine("4. Check Contains Item");
//    Console.WriteLine("5. Clear Stack");
//    Console.WriteLine("6. Display Stack");
//    Console.WriteLine("7. Exit");
//    Console.Write("Choose an option: ");

//    string choice = Console.ReadLine();

//    switch (choice)
//    {
//        case "1":
//            Console.Write("Enter number to push: ");
//            if (int.TryParse(Console.ReadLine(), out int number))
//            {
//                numberStack.Push(number);
//                Console.WriteLine($"Pushed: {number}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid number.");
//            }
//            break;
//        case "2":
//            if (numberStack.Count > 0)
//            {
//                int poppedNumber = numberStack.Pop();
//                Console.WriteLine($"Popped: {poppedNumber}");
//            }
//            else
//            {
//                Console.WriteLine("Stack is empty.");
//            }
//            break;
//        case "3":
//            if (numberStack.Count > 0)
//            {
//                int topNumber = numberStack.Peek();
//                Console.WriteLine($"Top item: {topNumber}");
//            }
//            else
//            {
//                Console.WriteLine("Stack is empty.");
//            }
//            break;
//        case "4":
//            Console.Write("Enter number to check: ");
//            if (int.TryParse(Console.ReadLine(), out int checkNumber))
//            {
//                bool contains = numberStack.Contains(checkNumber);
//                Console.WriteLine(contains ? "Item exists in the stack." : "Item does not exist in the stack.");
//            }
//            else
//            {
//                Console.WriteLine("Invalid number.");
//            }
//            break;
//        case "5":
//            numberStack.Clear();
//            Console.WriteLine("Stack cleared.");
//            break;
//        case "6":
//            if (numberStack.Count > 0)
//            {
//                Console.WriteLine("Current Stack Items:");
//                foreach (var item in numberStack)
//                {
//                    Console.WriteLine(item);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Stack is empty.");
//            }
//            break;
//        case "7":
//            exit = false;
//            Console.WriteLine("Exiting the program.");
//            break;
//        default:
//            Console.WriteLine("Invalid choice. Please try again.");
//            break;
//    }
//}

//4.(B) Create a Queue which takes integer values and perform following operations: 
//    a.Enqueue() - Adds an item into the queue.
//    b. Dequeue() - Returns an item from the beginning of the queue and removes it from the queue.
//    c. Peek() - Returns an rst item from the queue without removing it.
//    d. Contains() - Checks whether an item is in the queue or not
//    e. Clear() - Removes all the items from the queue
//using System;
//using System.Collections.Generic;
//using System.Collections;

//Queue<int> numberQueue = new Queue<int>();
//bool exit = true;
//while (exit)
//{
//    Console.WriteLine("\nQueue Management System");
//    Console.WriteLine("1. Enqueue Item");
//    Console.WriteLine("2. Dequeue Item");
//    Console.WriteLine("3. Peek Item");
//    Console.WriteLine("4. Check Contains Item");
//    Console.WriteLine("5. Clear Queue");
//    Console.WriteLine("6. Display Queue");
//    Console.WriteLine("7. Exit");
//    Console.Write("Choose an option: ");
//    string choice = Console.ReadLine();
//    switch (choice)
//    {
//        case "1":
//            Console.Write("Enter number to enqueue: ");
//            if (int.TryParse(Console.ReadLine(), out int number))
//            {
//                numberQueue.Enqueue(number);
//                Console.WriteLine($"Enqueued: {number}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid number.");
//            }
//            break;
//        case "2":
//            if (numberQueue.Count > 0)
//            {
//                int dequeuedNumber = numberQueue.Dequeue();
//                Console.WriteLine($"Dequeued: {dequeuedNumber}");
//            }
//            else
//            {
//                Console.WriteLine("Queue is empty.");
//            }
//            break;
//        case "3":
//            if (numberQueue.Count > 0)
//            {
//                int frontNumber = numberQueue.Peek();
//                Console.WriteLine($"Front item: {frontNumber}");
//            }
//            else
//            {
//                Console.WriteLine("Queue is empty.");
//            }
//            break;
//        case "4":
//            Console.Write("Enter number to check: ");
//            if (int.TryParse(Console.ReadLine(), out int checkNumber))
//            {
//                bool contains = numberQueue.Contains(checkNumber);
//                Console.WriteLine(contains ? "Item exists in the queue." : "Item does not exist in the queue.");
//            }
//            else
//            {
//                Console.WriteLine("Invalid number.");
//            }
//            break;
//        case "5":
//            numberQueue.Clear();
//            Console.WriteLine("Queue cleared.");
//            break;
//        case "6":
//            if (numberQueue.Count > 0)
//            {
//                Console.WriteLine("Current Queue Items:");
//                foreach (var item in numberQueue)
//                {
//                    Console.WriteLine(item);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Queue is empty.");
//            }
//            break;
//        case "7":
//            exit = false;
//            Console.WriteLine("Exiting the program.");
//            break;
//        default:
//            Console.WriteLine("Invalid choice. Please try again.");
//            break;
//    }
//}


//5.(C) Create a Dictionary collection class object and preform following operations:
//    a.Add: Adds a key-value pair.
//    b. Remove: Removes a key-value pair by key.
//    c. ContainsKey: Checks if a key exists in the hashtable.
//    d. ContainsValue: Checks if a value exists in the hashtable.
//    e. Clear: Removes all key-value pairs.
//using System;
//using System.Collections.Generic;
//using System.Collections;

//            Dictionary<string, string> studentDictionary = new Dictionary<string, string>();
//            bool exit = true;
//            while (exit)
//            {
//                Console.WriteLine("\nDictionary Management System");
//                Console.WriteLine("1. Add Key-Value Pair");
//                Console.WriteLine("2. Remove Key-Value Pair");
//                Console.WriteLine("3. Check Contains Key");
//                Console.WriteLine("4. Check Contains Value");
//                Console.WriteLine("5. Clear All Pairs");
//                Console.WriteLine("6. Display All Pairs");
//                Console.WriteLine("7. Exit");
//                Console.Write("Choose an option: ");

//                string choice = Console.ReadLine();
//                switch (choice)
//                {
//                    case "1":
//                        Console.Write("Enter Key: ");
//                        string key = Console.ReadLine();
//                        Console.Write("Enter Value: ");
//                        string value = Console.ReadLine();
//                        if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
//                        {
//                            studentDictionary.Add(key, value);
//                            Console.WriteLine($"Added: {key} - {value}");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Invalid key or value.");
//                        }
//                        break;
//                    case "2":
//                        Console.Write("Enter Key to Remove: ");
//                        string removeKey = Console.ReadLine();
//                        if (studentDictionary.Remove(removeKey))
//                        {
//                            Console.WriteLine($"Removed key: {removeKey}");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Key not found.");
//                        }
//                        break;
//                    case "3":
//                        Console.Write("Enter Key to Check: ");
//                        string checkKey = Console.ReadLine();
//                        if (studentDictionary.ContainsKey(checkKey))
//                        {
//                            Console.WriteLine($"Key '{checkKey}' exists.");
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Key '{checkKey}' does not exist.");
//                        }
//                        break;
//                    case "4":
//                        Console.Write("Enter Value to Check: ");
//                        string checkValue = Console.ReadLine();
//                        if (studentDictionary.ContainsValue(checkValue))
//                        {
//                            Console.WriteLine($"Value '{checkValue}' exists.");
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Value '{checkValue}' does not exist.");
//                        }
//                        break;
//                    case "5":
//                        studentDictionary.Clear();
//                        Console.WriteLine("All pairs cleared.");
//            break;
//        case "6":
//            if (studentDictionary.Count > 0)
//            {
//                Console.WriteLine("Current Key-Value Pairs:");
//                foreach (var pair in studentDictionary)
//                {
//                    Console.WriteLine($"{pair.Key} - {pair.Value}");
//                }
//            }
//            else
//            {
//                Console.WriteLine("No key-value pairs in the dictionary.");
//            }
//            break;
//        case "7":
//            exit = false;
//            Console.WriteLine("Exiting the program.");
//            break;
//        default:
//            Console.WriteLine("Invalid choice. Please try again.");
//            break;
//    }
//}

//6.(C) Create a Hashtable collection class object and preform following operations:
//    a.Add: Adds a key-value pair.
//    b. Remove: Removes a key-value pair by key.
//    c. ContainsKey: Checks if a key exists in the hashtable.
//    d. ContainsValue: Checks if a value exists in the hashtable.
//    e. Clear: Removes all key-value pairs. 
//using System;
//using System.Collections;
//using System.Collections.Generic;

//            Hashtable studentHashtable = new Hashtable();
//            bool exit = true;
//            while (exit)
//            {
//                Console.WriteLine("\nHashtable Management System");
//                Console.WriteLine("1. Add Key-Value Pair");
//                Console.WriteLine("2. Remove Key-Value Pair");
//                Console.WriteLine("3. Check Contains Key");
//                Console.WriteLine("4. Check Contains Value");
//                Console.WriteLine("5. Clear All Pairs");
//                Console.WriteLine("6. Display All Pairs");
//                Console.WriteLine("7. Exit");
//                Console.Write("Choose an option: ");
//                string choice = Console.ReadLine();
//                switch (choice)
//                {
//                    case "1":
//                        Console.Write("Enter Key: ");
//                        string key = Console.ReadLine();
//                        Console.Write("Enter Value: ");
//                        string value = Console.ReadLine();
//                        if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
//                        {
//                            studentHashtable.Add(key, value);
//                            Console.WriteLine($"Added: {key} - {value}");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Invalid key or value.");
//                        }
//                        break;
//                    case "2":
//                        Console.Write("Enter Key to Remove: ");
//                        string removeKey = Console.ReadLine();
//                        if (studentHashtable.ContainsKey(removeKey))
//                        {
//                            studentHashtable.Remove(removeKey);
//                            Console.WriteLine($"Removed key: {removeKey}");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Key not found.");
//                        }
//                        break;
//                    case "3":
//                        Console.Write("Enter Key to Check: ");
//                        string checkKey = Console.ReadLine();
//                        if (studentHashtable.ContainsKey(checkKey))
//                        {
//                            Console.WriteLine($"Key '{checkKey}' exists.");
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Key '{checkKey}' does not exist.");
//                        }
//                        break;
//                    case "4":
//                        Console.Write("Enter Value to Check: ");
//                        string checkValue = Console.ReadLine();
//                        if (studentHashtable.ContainsValue(checkValue))
//                        {
//                            Console.WriteLine($"Value '{checkValue}' exists.");
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Value '{checkValue}' does not exist.");
//                        }
//                        break;
//                    case "5":
//                        studentHashtable.Clear();
//                        Console.WriteLine("All pairs cleared.");
//            break;
//        case "6":
//            if (studentHashtable.Count > 0)
//            {
//                Console.WriteLine("Current Key-Value Pairs:");
//                foreach (DictionaryEntry pair in studentHashtable)
//                {
//                    Console.WriteLine($"{pair.Key} - {pair.Value}");
//                }
//            }
//            else
//            {
//                Console.WriteLine("No key-value pairs in the hashtable.");
//            }
//            break;
//        case "7":
//            exit = false;
//            Console.WriteLine("Exiting the program.");
//            break;
//        default:
//            Console.WriteLine("Invalid choice. Please try again.");
//            break;
//    }
//}
     




















