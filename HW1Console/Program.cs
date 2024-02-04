using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Ввод - Вывод 1
        //Console.Write("Enter your firstname: ");
        //string firstName = Console.ReadLine();
        //Console.Write("Enter your lastname: ");
        //string lastName = Console.ReadLine();
        //Console.Write("Enter your age: ");
        //string age = Console.ReadLine();
        //Console.Write("Enter your height: ");
        //string height = Console.ReadLine();
        //Console.Write("Enter your weight: ");
        //string weight = Console.ReadLine();
        //var strGluing = GetString(firstName, lastName, age, height, weight);
        //Program.PrintALine(strGluing);
        //var strFormatting = GetString(firstName, lastName, age, height, weight);
        //Program.PrintALine(strFormatting);
        //var strInterpolation = GetString(firstName, lastName, age, height, weight);
        //Program.PrintALine(strInterpolation);
        
        //Ввод - вывод 2
        //Console.WriteLine(BMI(1.60,60));
        
        //Ввод - вывод 3
        //double r = FindingTheDistanceBetweenPoints(0.5, 2, 0.5, 2);
        //Console.WriteLine(r.ToString("F", CultureInfo.InvariantCulture));
        
        //Ввод вывод 4
        //var tuple = ExchangeOfValuesOfTwoVariablesThroughThreeVariables(2, 3);
        //Console.WriteLine(tuple);
        //var tuple = ExchangeOfValuesOfTwoVariablesThroughTwoVariables(2, 3);
        //Console.WriteLine(tuple);
        
        //Ввод - вывод 5
        //Program.PrintALine(GetALine("Anastasia", "Zaborskaya", "Barnaul"));
        //Program.PrintALine(Print("Anastasia, Zaborskaya, Barnaul", 100,5));
    }
    // метод для вывода строки
    public static void PrintALine(string line)
    {
        Console.WriteLine(line);
    }
    
    //1а Написать программу «Анкета».Последовательно задаются вопросы (имя,фамилия,возраст, рост, вес). В результате вся информация выводится в одну строчку: а) используя  склеивание;
    public static string GetString(string firstName, string lastname, string age, string height, string weight)
    {
        return firstName + lastname + age + height + weight;
    }
    
    //1б б) используя форматированный вывод;
    public static string GetStringUsingFormattedOutput(string firstName, string lastname, string age, string height, string weight)
    {
        return string.Format("firstName: {0}, lastName: {1}, age: {2}, height: {3}, weight: {4}", firstName, lastname, age, height, weight);
    }
    
    //1в используя вывод со знаком $.
    public static string GetStringUsingInterpolation(string firstName, string lastname, string age, string height, string weight)
    {
        return $"firstName: {firstName}, lastName: {lastname}, age: {age}, height: {height}, weight: {weight}";
    }
    
    //2 Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
    public static double BMI(double height, double weight)
    {
        return Math.Round((weight / Math.Pow(height, 2)), 2);
    }
    
    //3a,b  а)Написать программу,которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    public static double FindingTheDistanceBetweenPoints(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 1) + Math.Pow(y2 - y1, 2));
    }
    
    //4а  Написать программу обмена значениями двух переменных:с использованием третьей переменной
    public static (double, double) ExchangeOfValuesOfTwoVariablesThroughThreeVariables(double a, double b)
    {
        double c = a;
        a = b;
        b = c;
        var result = (a, b);
        return result;
    }
    
    //4б  Написать программу обмена значениями двух переменных:*без использования третьей переменной
    public static (double, double) ExchangeOfValuesOfTwoVariablesThroughTwoVariables(double a, double b)
    {
        (a, b) = (b, a);
        return (a, b);
    }
    
    //5a  Написать программу, которая выводит на экран ваше имя, фамилию и город проживания
    public static string GetALine(string firstName, string lastname, string city)
    {
        return $"firstName: {firstName}, lastName: {lastname}, city: {city}";
    }
    
    //5 б,в б) *Сделать задание, только вывод организовать в центре экрана. в)**Сделатьзаданиебсиспользованиемсобственныхметодов(например,Print(stringms, int x,int y).
    public static string Print(string ms, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        return string.Format($"ms: {ms}");
    }
}