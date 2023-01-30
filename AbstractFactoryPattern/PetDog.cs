namespace AmelyCordova_AppWebAbstractFactory.AbstractFactoryPattern
{
    class PetDog : IDog
    {
        public HttpResponse _response => new HttpContextAccessor().HttpContext.Response;
        public void Speak()
        {
            _response.WriteAsync("Pet Dog dice: Bow-Wow.\n\n");
        }
        public void Action()
        {
            _response.WriteAsync("Pet Dogs prefieren quedarse en casa.\n\n");
        }
    }
}
