﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest.Generics1
{
    internal static class ClientGeneric1
    {
        //static List<BaseClass> baseList = new List<BaseClass>();

        //public static void Run()
        //{
        //    //var baseList = new List<IProperty>();
        //    var baseList = new List<BaseClass>();
        //    var element1 = new MEPCurve() { Name = "mepCurve" };
        //    //var class1 = new Class1() { Name = "class1", MyElement = element1 };
        //    var class1 = new Class1() { Name = "class1", MyElement = element1 };
        //    class1.MyElementType.MEPId = 1;
        //    var element2 = new Element() { Name = "element" };
        //    var class2 = new Class2() { Name = "class2", MyElement = element2 };
        //    class2.MyElementType.ElementId = 2;

        //    baseList.Add(class1);
        //    baseList.Add(class2);


        //    foreach (var item in baseList)
        //    {
        //        Console.WriteLine(item.Name + " - " + item.MyElement.Name);
        //    }


        //    Console.WriteLine("\n class1 types:");
        //    var class1Types = baseList.OfType<Class1>();
        //    foreach (var item in class1Types)
        //    {
        //        var prop1 = item.MyElement.Name;
        //        var prop2 = item.MyElementType.MEPId;
        //        Console.WriteLine(item.Name + " - " + prop1 + " - " + prop2);
        //    }

        //    Console.WriteLine("\n class2 types:");
        //    var class2Types = baseList.OfType<Class2>();
        //    foreach (var item in class2Types)
        //    {
        //        var prop1 = item.MyElement.Name;
        //        var prop2 = item.MyElementType.ElementId;
        //        Console.WriteLine(item.Name + " - " + prop1 + " - " + prop2);
        //    }
        //}


        public static void Run()
        {
            //var baseList = new List<IProperty>();
            var list = new List<IProperty>();


            var element1 = new Element() { Name = "element", ElementId = 1 };
            var class1 = new Class1() { Name = "class1", MyElement = element1 };

            var element2 = new MEPCurve() { Name = "mepCurve" , MEPId = 2};
            var class2 = new Class2();

            list.Add(class1);
            list.Add(class2);

            //var baseTypes = list.Cast<BaseClass<BaseElement>>().ToList();
            //List<BaseClass<BaseElement>> baseTypes = list.OfType<BaseClass<BaseElement>>().ToList();
            //foreach (var item in baseTypes)
            //{
            //    Console.WriteLine(item.Name + " - " + item.MyElement.Name);
            //}

            foreach (var item in list)
            {
                var baseItem = (BaseClass<BaseElement>)item;
                Console.WriteLine(baseItem.Name + " - " + baseItem.MyElement.Name);
            }


            Console.WriteLine("\n class1 types:");
            var class1Types = list.OfType<Class1>();
            foreach (var item in class1Types)
            {
                var prop1 = item.MyElement.Name;
                var prop2 = item.MyElement.ElementId;
                Console.WriteLine(item.Name + " - " + prop1 + " - " + prop2);
            }

            Console.WriteLine("\n class2 types:");
            var class2Types = list.OfType<Class2>();
            foreach (var item in class2Types)
            {
                var prop1 = item.MyElement.Name;
                var prop2 = item.MyElement.MEPId;
                Console.WriteLine(item.Name + " - " + prop1 + " - " + prop2);
            }
        }

    }
}
