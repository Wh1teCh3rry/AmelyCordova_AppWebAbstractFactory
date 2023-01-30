namespace AmelyCordova_AppWebAbstractFactory.AbstractFactoryPattern
{
    class WildDog : IDog
    {
        public HttpResponse _response => new HttpContextAccessor().HttpContext.Response;
        public void Speak()
        {
            _response.WriteAsync("Wild Dog dice: Bow-Wow.\n\n");
        }
        public void Action()
        {
            _response.WriteAsync("Wild Dogs prefieren vagar libremente en las selvas.\n\n");
        }
    }
}
