namespace AmelyCordova_AppWebAbstractFactory.AbstractFactoryPattern
{
    class WildTiger : ITiger
    {
        public HttpResponse _response => new HttpContextAccessor().HttpContext.Response;
        public void Speak()
        {
            _response.WriteAsync("Wild Tiger dice: Halum.\n\n");
        }
        public void Action()
        {
            _response.WriteAsync("Wild Tigers prefieren cazar en selvas.\n\n");
        }
    }
}
