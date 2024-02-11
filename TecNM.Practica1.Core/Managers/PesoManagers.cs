using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;
public class PesoManagers : IPesoManagers{

    //Nomeclatura de buenas prácticas cuando algo sea privado _.
    private readonly IPESOServices _service;
    public PesoManagers (IPESOServices service){
    _service = service;
    }

    public Peso GetPeso (Person person){
    return _service.ProcessBMI(person);
    }
}