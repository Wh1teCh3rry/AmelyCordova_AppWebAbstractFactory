namespace AmelyCordova_AppWebAbstractFactory.AbstractFactoryPattern
{
    public class WildAnimalFactory : IAnimalFactory
    {
        public IDog GetDog()
        {
            return new WildDog();
        }
        public ITiger GetTiger()
        {
            return new WildTiger();
        }
    }
}
