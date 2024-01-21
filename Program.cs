using System;

namespace classesAndObjectChallenge 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name, place;
            int age, year;
            int eng, sci, math, tle, fil, his, rel, pe;
            
            gradeSystem grade = new gradeSystem();

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your place: ");
            place = Console.ReadLine();

            Console.WriteLine("Enter your grade in English: ");
            eng = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(grade.englishGrade(eng));
              
            Console.WriteLine("Enter your grade in Science: ");
            sci = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(grade.scienceGrade(sci));

            Console.WriteLine("Enter your grade in Math: ");
            math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(grade.mathGrade(math));

            Console.WriteLine("Enter your grade in TLE: ");
            tle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(grade.tleGrade(tle));

            Console.WriteLine("Enter your grade in Filipino: ");
            fil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(grade.filipinoGrade(fil));

            Console.WriteLine("Enter your grade in History: ");
            his = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(grade.historyGrade(his));

            Console.WriteLine("Enter your grade in Religion: ");
            rel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(grade.religionGrade(rel));

            Console.WriteLine("Enter your grade in PE: ");
            pe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(grade.peGrade(pe));

            Console.WriteLine("====================STUDENT INFORMATION====================");
            studentInfo info = new studentInfo();
            info.info(name, age, year, place);
           
           Console.WriteLine("====================FINAL GRADE====================");
           studentAverage avg = new studentAverage();

           Console.WriteLine("AVERAGE: " + avg.gettingAverage(eng, sci, math, tle, fil, his, rel, pe));

           avg.finalResult(eng, sci, math, tle, fil, his, rel, pe);
        }
    }
}
