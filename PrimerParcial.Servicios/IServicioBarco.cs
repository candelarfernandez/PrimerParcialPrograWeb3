using PrimerParcial.Entidades;

namespace PrimerParcial.Servicios
{
    public interface IServicioBarco
    {
        public void RegistrarBarco(Barco barco);
        public List<Barco> ObtenerBarcos();
    }
    public class ServicioBarco : IServicioBarco
    {
        private static List<Barco> barcos = new List<Barco>();
        private int id = 0;
        public ServicioBarco() { }

        public void RegistrarBarco(Barco barco)
        {
            barco.id = ++id;
            barco.tasa = (barco.antiguedad * 0.10) + (barco.tripulacionMaxima / 2);
            barcos.Add(barco);
        }
        public List<Barco> ObtenerBarcos()
        {
            return barcos.ToList();
        }
    }
}
