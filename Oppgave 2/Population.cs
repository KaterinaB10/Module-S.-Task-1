namespace Module_S._Task_1{

    public class Population
    {
       public double CalculatePopulationGrowth(){
        double population1950 = 2.5;
        double population2024 = 7.9;
        return population2024 - population1950;
       }

       public double CalculatePopulationInFuture() {
        double population1950 = 2.5;
        double population2024 = 7.9;
        double yearsQuantity = 25;
        double populationGrowth = population2024 - population1950;

        return population2024 + populationGrowth / (2024-1950) * yearsQuantity;
    }
    }

}