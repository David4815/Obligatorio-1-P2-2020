using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        #region Variables y Listas
        private static double cotizacionDolar = 43.2;
        private static Sistema instanciaSistema;
        private List<Destino> listaDestinos = new List<Destino>();
        private List<CompaniaAerea> listaCompaniasAereas = new List<CompaniaAerea>();
        private List<Excursion> listaExcursiones = new List<Excursion>();
        #endregion

        #region Constructor
        private Sistema()
        {
            this.listaDestinos = new List<Destino>();
            this.listaCompaniasAereas = new List<CompaniaAerea>();
            this.listaExcursiones = new List<Excursion>();
        }
        #endregion

        #region Propiedades
        public List<Destino> ListaDestinos
        {
            get { return listaDestinos; }
            //set { listaDestinos = value; }
        }

        public List<Excursion> ListaExcursiones
        {
            get { return listaExcursiones; }
            //set { listaExcursiones = value; }
        }

        public List<CompaniaAerea> ListaCompaniasAereas
        {
            get { return listaCompaniasAereas; }
            //set { listaCompaniasAereas = value; }
        }



        public static double CotizacionDolar
        {
            get { return cotizacionDolar; }
            set { cotizacionDolar = value; }
        }





        public static Sistema InstanciaSistema
        {

            get
            {
                if (instanciaSistema == null)
                {
                    instanciaSistema = new Sistema();
                }
                return instanciaSistema;
            }

        }

        #endregion


        #region Metodos

        public void IngresarDestino(string ciudad, string pais, int cantidadDias, int costoActualDiario)
        {
            Destino unDestino = new Destino(ciudad, pais, cantidadDias, costoActualDiario);
            this.listaDestinos.Add(unDestino);
        }

        public void PrecargarDestinos()
        {
            IngresarDestino("Montevideo", "Uruguay", 3, 120);
            IngresarDestino("Canelones", "Uruguay", 3, 120);
            IngresarDestino("Rivera", "Uruguay", 3, 120);
            IngresarDestino("Buenos Aires", "Argentina", 3, 120);
            IngresarDestino("Brasilia", "Brasil", 3, 120);
            IngresarDestino("Cuzco", "Peru", 3, 120);
            IngresarDestino("Sucre", "Bolivia", 3, 120);
            IngresarDestino("Santiago de Chile", "Chile", 3, 120);
            IngresarDestino("Hanoi", "Vietnam", 3, 120);
            IngresarDestino("Canberra", "Australia", 3, 120);
        }

        public void IngresarExcursionNacional(string descripcion, DateTime fechaComienzo, int cantidadDias, int stock, bool interesNacional)
        {
            ExcursionNacional unaExursion = new ExcursionNacional(descripcion, fechaComienzo, cantidadDias, stock, interesNacional);
        }

        public void PrecargarExcursiones()
        {
            CompaniaAerea unaCompaniaAerea = new CompaniaAerea(22, "Urguay");

            ExcursionNacional Excursion1 = new ExcursionNacional("una descripcion", new DateTime(2020,09,26), 5, 20, true);
            Excursion1.ListaDestinosDisponibles.Add(listaDestinos[0]);
            Excursion1.ListaDestinosDisponibles.Add(listaDestinos[1]);
            ExcursionNacional Excursion2 = new ExcursionNacional("una descripcion", new DateTime(2020, 09, 26), 5, 20, true);
            Excursion2.ListaDestinosDisponibles.Add(listaDestinos[2]);
            Excursion2.ListaDestinosDisponibles.Add(listaDestinos[3]);
            ExcursionNacional Excursion3 = new ExcursionNacional("una descripcion", new DateTime(2020, 09, 26), 5, 20, true);
            Excursion3.ListaDestinosDisponibles.Add(listaDestinos[3]);
            Excursion3.ListaDestinosDisponibles.Add(listaDestinos[4]);
            ExcursionNacional Excursion4 = new ExcursionNacional("una descripcion", new DateTime(2020, 09, 26), 5, 20, true);
            Excursion4.ListaDestinosDisponibles.Add(listaDestinos[5]);
            Excursion4.ListaDestinosDisponibles.Add(listaDestinos[6]);
            ExcursionInternacional Excursion5 = new ExcursionInternacional("una descripcion", new DateTime(2020, 09, 26), 5, 20, unaCompaniaAerea);
            Excursion5.ListaDestinosDisponibles.Add(listaDestinos[7]);
            Excursion5.ListaDestinosDisponibles.Add(listaDestinos[8]);
            ExcursionInternacional Excursion6 = new ExcursionInternacional("una descripcion", new DateTime(2020, 09, 02), 5, 20, unaCompaniaAerea);
            Excursion6.ListaDestinosDisponibles.Add(listaDestinos[9]);
            Excursion6.ListaDestinosDisponibles.Add(listaDestinos[1]);
            ExcursionInternacional Excursion7 = new ExcursionInternacional("una descripcion", new DateTime(2020, 09, 26), 5, 20, unaCompaniaAerea);
            Excursion7.ListaDestinosDisponibles.Add(listaDestinos[8]);
            Excursion7.ListaDestinosDisponibles.Add(listaDestinos[1]);
            ExcursionInternacional Excursion8 = new ExcursionInternacional("una descripcion", new DateTime(2020, 09, 26), 5, 20, unaCompaniaAerea);
            Excursion8.ListaDestinosDisponibles.Add(listaDestinos[7]);
            Excursion8.ListaDestinosDisponibles.Add(listaDestinos[1]);

            this.listaExcursiones.Add(Excursion1);
            this.listaExcursiones.Add(Excursion2);
            this.listaExcursiones.Add(Excursion3);
            this.listaExcursiones.Add(Excursion4);
            this.listaExcursiones.Add(Excursion5);
            this.listaExcursiones.Add(Excursion6);
            this.listaExcursiones.Add(Excursion7);
            this.listaExcursiones.Add(Excursion8);

        }

        //podria hacer un metodo que devuelva un lista de las excursiones que esten entre esas dos fechas asi no tiene consolewr
        public static List<Excursion> ExcursionesEntre(int unCodigoDestino, DateTime inicio, DateTime fin, List<Excursion> instanciaSistemaListaExcursiones, List<Destino> instanciaSistemaListaDestinos)
        {
            List<Excursion> listaBuscada = new List<Excursion>();

            foreach (Excursion i in instanciaSistemaListaExcursiones)
            {
                if (i.FechaComienzo > inicio && i.FechaComienzo < fin)
                {

                    foreach (Destino j in i.ListaDestinosDisponibles)
                    {

                        if (unCodigoDestino - 1 == instanciaSistemaListaDestinos.IndexOf(j))
                        {
                            listaBuscada.Add(i);
                        }
                    }

                }

            }

            return listaBuscada;
        }
        #endregion








    }
}
