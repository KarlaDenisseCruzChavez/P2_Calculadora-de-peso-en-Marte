using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class PESOServices: IPESOServices{
    public Peso ProcessBMI (Person person){
        var bmi = new Peso();

        bmi.index = (person.Weight / 9.81) * 3.711;

        return bmi;
    }
}