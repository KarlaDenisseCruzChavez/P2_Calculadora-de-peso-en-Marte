using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;


namespace TecNM.Practica1.App;

public static class Program{
    public static void Main(string[] args){

       
        float weight = 0;

        
        Console.WriteLine("Escribe tu peso: ");
        //castea
        Single.TryParse(System.Console.ReadLine(), out weight);

        
        var person = new Person {Weight = weight};

        var service = new PESOServices();
        var managers = new PesoManagers(service);

        Peso bmi = managers.GetPeso(person);
        Console.WriteLine($"Peso en Marte {bmi.index} ");
    }
}
