using System;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; // المتغير الذي سنحفظ فيه الرقم النهائي

            Console.Write("please enter number: ");

            // دالة TryParse تقرأ النص، وإذا فشلت في تحويله لرقم ترجع false فيعمل اللوب
            while (!int.TryParse(Console.ReadLine(),out number))
            {
                // إذا أدخل نصاً بدلاً من الرقم، سيطبع هذا الخطأ ويطلب منه الإدخال مجدداً
                Console.WriteLine("إدخال خاطئ! الرجاء إدخال أرقام فقط وليس نصوص.");
                Console.Write("حاول مرة أخرى وأدخل رقماً: ");
            }

            // بمجرد أن يدخل رقماً صحيحاً، سيتوقف اللوب وينتقل البرنامج لهنا
            Console.WriteLine($"ممتاز! لقد أدخلت الرقم: {number}");
        }
    }
}