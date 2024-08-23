namespace BlazorApp2.Models
{
    public class Navigatore
    {
        public List<Pagina> paginaList;
        public Navigatore()
        {
            paginaList  = new List<Pagina>();
        }
        public void AggiungiCronologia(Pagina pagina)
        {
            paginaList.Add(pagina);
        }
        public void CancellaCronologia()
        {
            paginaList.Clear();
        }
    }
}
