namespace BlazorApp2.Models
{
    public class Pagina
    {
        public string indirizzo;
        public DateTime oraAccesso;
        public int tempodivisita;
        public Pagina()
        {
            indirizzo = string.Empty;
            tempodivisita = 0;
            oraAccesso = DateTime.Now;
        }
        public void SalvaTempoVisita(int tvisita)
        {
            tempodivisita = tvisita;
        }
    }
}
