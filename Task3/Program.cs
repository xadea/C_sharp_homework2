﻿// программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным

string[] Days = {"Mondey", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        for (int i=0; i<Days.Length-1; i++)
        {
            Console.Write(i+1 + "-" + Days[i] + ", ");
        }
    Console.WriteLine(Days.Length + "-" + Days[Days.Length-1] + ", ");
    Console.WriteLine("Choose a day");
    int numberDay = Convert.ToInt32(Console.ReadLine());
    if (numberDay>0)
    {
        if (numberDay<8)
        {
            if(numberDay >5) Console.WriteLine("Yahoo! Is's a weekend day!");
            else Console.WriteLine("Sorry, is's a weekday. ");
        }
        else Console.WriteLine("There is no day number " + numberDay);
    }
    else Console.WriteLine("There is no day number " + numberDay);