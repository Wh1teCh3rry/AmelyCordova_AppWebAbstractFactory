namespace AmelyCordova_AppWebAbstractFactory.AbstractFactoryPattern
{
    class PetTiger : ITiger
    {
        public HttpResponse _response => new HttpContextAccessor().HttpContext.Response;
        public void Speak()
        {
            _response.WriteAsync("Pet Tiger dice: Halum.\n\n");
        }
        public void Action()
        {
            _response.WriteAsync("Pet Tigers jugar en un circo de animales.\n\n");
        }
    }
}
