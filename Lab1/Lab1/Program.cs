﻿namespace Lab1
{
    class firstclass {
        static void Main(string[] args)
        {
            //         1) Типы
            //task A
            bool a1 = true;
            char a2 = 'g';
            long a3 = 12312313;
            decimal a4 = 132.41234m;
            float a5 = 5.5f;
            short a6 = -12314;
            int a7 = 10;
            double a8 = 7.1234123;
            Console.WriteLine(".........1)Типы..........\n ----Task A----\n Bool = {0} \n Char = {1} \n Long = {2} \n Decimal = {3} \n Float = {4} \n " +
                "Short = {5} \n Int = {6}\n Double = {7}\n ", a1, a2, a3, a4, a5, a6, a7, a8);
            //task B
            int b1 = Convert.ToInt16(0.981231);  //1 явное
            Console.WriteLine("----Task B---- \n b1 = " + b1 + " , " + b1.GetType());
            long b2 = (long)b1; //2 явное
            short b3 = (short)b2 ; //3 явное
            bool b4 = Convert.ToBoolean(b3); //4 явное
            Console.WriteLine("short ---> bool, now b4 = " + b4);
            int b5 = Convert.ToInt32(b4); //5 явное
            Console.WriteLine("type of b5 is {0}", b5.GetType(), '\n');

            float b6 = 1.2123123f;
            double b7 = b6; // float -> double (1)
            byte b8 = 8;
            short b9 = b8; // byte -> short (2)
            b1 = b9; // short -> int    (3)
            b2 = b1; // int -> long (4)
            double b10 = b1; // int -> double (5)
            // task C
            int i = 123;
            object o = i;
            o = 123;
            i = (int)o;
            //task D
            var a = 28;
            var b = 1.123412;
            Console.WriteLine("\n----Task D----\nvar a is " + a.GetType() + ", var b is" + b.GetType());
            var c = a + b;
            Console.WriteLine("var c is " + a.GetType());
            //task E
            Console.WriteLine("\n----Task E----\n" );
            int? e1  = null;
            int? e2 = null;
            Console.WriteLine("Compairing nullable = {0}\nSum of nullable = {1}", e1 == e2, e1 + e2 );
            //task F
            Console.WriteLine("\n----Task F----\n");
            var f1 = 123.12312;
            f1 = 12;
            Console.WriteLine("f1 = {0}, {1}", f1, f1.GetType());
            //2)  Строки
            //Task A
            Console.WriteLine(".........2)Строки..........\n----Task A----\n");
            string s1 = "wex";
            string s2 = "wex";
            string s3 = "notwex";
            Console.WriteLine($"Compairing strings s1 и s2: {s1 == s2}");
            Console.WriteLine($"Compairing strings s2 и s3 : {s2 == s3}");
            //Task B
            Console.WriteLine("\n----Task B----\n");
            string str1 = "exort";
            string str2 = "some words here";
            string str3 = "amg";
            Console.WriteLine("concantenation: " + String.Concat(str1,str2));
            Console.WriteLine("Copirovanie: " + String.Copy(str1));
            Console.WriteLine("SUBSTRING: " + str2.Substring(5));
            string[] str4 = str2.Split(' ');
            Console.WriteLine("Splitint str2:");
            foreach ( var asd in str4)
            {
                Console.WriteLine(asd);
            }
            Console.WriteLine("Inserting string in string: " + str3.Insert(2, str1));
            Console.WriteLine("Deleting substring: " + str2.Remove(6) + "\n ----Task C----");
            //Task C
            string nllstr = null;
            string vstr = "";
            Console.WriteLine("isnullorempty on nullstr: {0} , on voidstr : {1}", string.IsNullOrEmpty(nllstr), 
                string.IsNullOrEmpty(vstr));
            Console.WriteLine("Equality of strings : " + (nllstr == vstr) + ", Concantenation: " + String.Concat(vstr,nllstr) + "\n ----Task D----\n");
            //Task D
        }

    }


}