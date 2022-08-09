// программа, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

// можно обойтись и без функции, но я, на всякий случай, сделала с ней
double ThirdNumber(double arg1, double arg2) 
{
    while(arg1>=100)
    {
        arg2 = arg1 % 10;
        arg1=(arg1-arg2)/10;
    }
    return arg2;
}

Console.WriteLine("I can guess the third digit in your number. Input number ");
double num1 = Convert.ToInt32(Console.ReadLine());
double num2 = 0;
if (num1<100) Console.WriteLine("Third number doesn't exist");
else
{
   double num3 = ThirdNumber(num1, num2);

    Console.WriteLine("Third number in " + num1 + " is " + num3);
}

