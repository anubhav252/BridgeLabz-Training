using System;
namespace MealPlanGenerator
{
    public interface IMealPlan
    {
        string MealName { get; }
        int Calories { get; }
        void DisplayMeal();
    }
    public class VegetarianMeal : IMealPlan
    {
        public string MealName => "Vegetarian Meal";
        public int Calories => 600;
        public void DisplayMeal()
        {
            Console.WriteLine("Vegetarian Meal: Rice, Lentils, Vegetables");
        }
    }
    public class HighProteinMeal : IMealPlan
    {
        public string MealName => "High Protein Meal";
        public int Calories => 800;

        public void DisplayMeal()
        {
            Console.WriteLine("High Protein Meal: Fish, Brown Rice, Beans");
        }
    }
    public class Meal<T> where T : IMealPlan, new()
    {
        public T CreateMeal()
        {
            return new T();
        }
    }
    public static class MealGenerator
    {
        public static void GenerateMealPlan<T>()
            where T : IMealPlan, new()
        {
        T meal = new T();
        Console.WriteLine("\n--- Meal Plan Generated ---");
        Console.WriteLine($"Meal Type: {meal.MealName}");
        Console.WriteLine($"Calories : {meal.Calories}");
        meal.DisplayMeal();
        }
    }

    class Program
{
        static void Main()
        {
            Meal<VegetarianMeal> vegetarian = new Meal<VegetarianMeal>();
            Meal<HighProteinMeal> protein = new Meal<HighProteinMeal>();

            MealGenerator.GenerateMealPlan<VegetarianMeal>();
            MealGenerator.GenerateMealPlan<HighProteinMeal>();
        }
    }
}