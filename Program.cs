using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace Module_S._Task_1{

class Program{

    static void Main(string[] args)
    {
        /* -------- Lag et par forskjellige variabler av typene: int, string, double -------- */
        string name = "Katerina";
        int age = 28;
        char module = 'S';
        Console.WriteLine("Name: " + name + ". Age: " + age + ". Module: " + module + ".");

        /* -------- Lag to forskjellige variabler som bruker datastrukturene:
        Array og List, prøv å skrive dem ut med Console.WriteLine() metoden
        og tenk over hvorfor de ikke kan skrives ut direkte til konsollen.-------- */
        Console.WriteLine("-----------------------------------------------");
        string[] modules = {"A", "B", "C", "D", "S"};

        /* -------- Variants of printing array -------- */
        Console.WriteLine(modules[0]);
        foreach(string el in modules){
            System.Console.WriteLine("Module " + el);
            };
        
        List<int> numbers = new List<int>(){
            10, 20, 30, 40, 50
        };
        /* -------- Variants of printing list -------- */
        Console.WriteLine(numbers[3]);
         foreach(int el in numbers){
        System.Console.WriteLine("Number from the list: " + el);
        };

        /* -------- Bruk for-loops til å skrive ut Array og List til konsollen,
        dersom vi har et array av typen string[] kan vi bruke en for-loop som
        itererer gjennom ved hjelp av lengden av arrayet,
        og med int[] kan vi bruke count for å telle antall elementer i arrayet istedenfor. -------- */
        Console.WriteLine("-----------------------------------------------");
        for(int i = 0; i < modules.Length; i++){
            Console.WriteLine(modules[i]);
        }
        int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sumOfNum = num.Count();
        Console.WriteLine("Amount of numbers is " + sumOfNum);

        /* -------- Forsøk å lage en klasse som bruker en constructor { get; set; }
        og kall den i Program.cs -------- */
        Console.WriteLine("-----------------------------------------------");
        List<City> cities = new List<City>();
        cities.Add(new City("X", 40000, 1000000));
        cities.Add(new City("Y", 5000, 1000000));
        cities.Add(new City("Z", 700000, 200000));
        cities.Add(new City("V", 1000, 80000000));
        cities.Add(new City("W", 800, 300));

        foreach(City obj in cities){
        Console.WriteLine(obj.name);}

        /* -------- Forsøk å lage noen enkle metoder som regner med tall gitt som parametre.
        Eksempel: ps( kan AddNumbers bruke desimaltall? Dersom den ikke kan,
        hvordan kan man fikse problemet?) -------- */
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Please enter 2 numbers");
        double UserInput1;
        UserInput1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your first number is " + UserInput1);
        double UserInput2;
        UserInput2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your second number is " + UserInput2);
        Console.WriteLine("Result is " + AddNumbers(UserInput1, UserInput2));

        /* -------- Bruk string metoder som f.eks String.Split(“”)
        og se hva som skjer med strengene og hvordan de manipuleres
        med disse innebygde metodene. -------- */
        Console.WriteLine("-----------------------------------------------");
        string StringForTest = "This is a task for C# course";
        Console.WriteLine(StringForTest.ToLower());
        Console.WriteLine(StringForTest.ToUpper());
        Console.WriteLine(String.Compare("hi", "hello") == 1 ? "The strings are different" : String.Compare("hi", "hello"));

        /* -------- Forsøk å lage et interface, tenk over hvilke metoder interface skal inneholde,
        og implementer dem i en ny klasse. -------- */
        Console.WriteLine("-----------------------------------------------");
        CarTime carTime = new CarTime();
        int totalTime = carTime.Time(100, 50);
        double hours = totalTime / 60.0;
        double minutes = totalTime % 60;
        Console.WriteLine("It will take " + hours + " hours to take to your location.");
        
        }
    static double AddNumbers(double a, double b)
    {
        return a + b;
    }

}}
