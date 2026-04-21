/*
generics allows us to define claasess methods or collections with a placeholder for datatype
so they work with any type while maintaining type safety.
we cannot use arraylist in c# because it doesnot provide typesafety means 
doesnot allows to save different datatypes elements.
so to overcome this problem we can use following method.
*/
// ArrayList  list = new ArrayList();
// list.Add(10);
// list.Add(20);
// list.Add("c#");

using System.Collections.Generic;
using System;
// namespace gen
// {
//     public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         List<int> num = new List<int>();

//         num.Add(10);
//         num.Add(20);

//         foreach(int n in num)
//         {
//             Console.WriteLine(n);
//         }
        
//     }
// }

// }

// generics for class

// public class HelloWorld
// {
//     class MyClass<T>
//     {
//         public T Data;

//         public void Show()
//         {
//             Console.WriteLine(Data);
//         }
//     }

//     public static void Main(string[] args)
//     {
//         MyClass<int> obj1 = new MyClass<int>();
//         obj1.Data = 100;
//         obj1.Show();

//         MyClass<string> obj2 = new MyClass<string>();
//         obj2.Data = "C# Generics";
//         obj2.Show();
//     }
// }

/*
write 2 examples for generics with its real time use in company levels
why company use generics.
*/