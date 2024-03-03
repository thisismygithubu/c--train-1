using System;

namespace ShiftCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            // دریافت مقدار x از کاربر
            Console.Write("لطفا مقدار x را وارد کنید: ");
            int x = Convert.ToInt32(Console.ReadLine());

            // محاسبه‌ی y بدون استفاده از عملگر ضرب
            int y = (x << 5) - (x << 4) + 5; // اینجا از عملگر شیفت به چپ برای جایگذاری عملگر ضرب استفاده شده است.
            int z = (y=31*x-17*x+5);
            // چاپ نتیجه
            Console.WriteLine($"مقدار y برابر است با: {y}"+$"x = : {z}");
        }
    }
}