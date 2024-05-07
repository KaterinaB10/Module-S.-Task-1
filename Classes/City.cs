using System;

namespace Module_S._Task_1{

class City {

     public string? name { get; private set; }
     public int square { get; private set; }
     public int population { get; private set; }


      public City(string name, int square, int population){
        this.name = name;
        this.square = square;
        this.population = population;
            // System.Console.WriteLine("City has been created");
        }
        
        public City() {}

         public void printInfoAboutCity(){
            System.Console.WriteLine("There is city" + name +
            ". The square of this city is " + square +
            ". And population - " + population + ".");
            }




}
}