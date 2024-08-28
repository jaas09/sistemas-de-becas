using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace becaEstudiantes
{
    class Nodo_Beca
    {
        string codEst;
        string nombre;
        string TipoAlumno;
        double promedio;
        double deportiva, cultural, excelencia, social, hermanos, hijoMilitar, ninguna;
        string carrera;
        double montoBeca;
        double mensualidad;
        Nodo_Beca enlace;
        public Nodo_Beca()
        {
            this.codEst ="";
            this.nombre = "";
            TipoAlumno = "";
            promedio = 0.0;
            deportiva=0.0;
            cultural = 0.0;

        }

        public string CodEst { get => codEst; set => codEst = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string TipoAlumno1 { get => TipoAlumno; set => TipoAlumno = value; }
        public double Promedio { get => promedio; set => promedio = value; }
        public double Deportiva { get => deportiva; set => deportiva = value; }
        public double Cultural { get => cultural; set => cultural = value; }
        public double Excelencia { get => excelencia; set => excelencia = value; }
        public double Social { get => social; set => social = value; }
        public double Hermanos { get => hermanos; set => hermanos = value; }
        public double HijoMilitar { get => hijoMilitar; set => hijoMilitar = value; }
        public double Ninguna { get => ninguna; set => ninguna = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public double MontoBeca { get => montoBeca; set => montoBeca = value; }
        public double Mensualidad { get => mensualidad; set => mensualidad = value; }
        public Nodo_Beca Enlace { get => enlace; set => enlace = value; }
    }
}
