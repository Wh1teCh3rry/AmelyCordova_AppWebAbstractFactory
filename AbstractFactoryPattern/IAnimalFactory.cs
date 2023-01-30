using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmelyCordova_AppWebAbstractFactory.AbstractFactoryPattern
{
    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
