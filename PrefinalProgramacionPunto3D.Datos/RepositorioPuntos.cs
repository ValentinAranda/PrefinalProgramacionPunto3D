using System;
using PrefinalProgramacionPunto3D.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrefinalProgramacionPunto3D.Datos
{
    public class RepositorioPuntos
    {
        private List<Punto3D>? punto;
        private string? nombreArchivo = "Punto3D.txt";
        private string? rutaProyecto = Environment.CurrentDirectory;
        private string? rutaCompletaArchivo;

        public RepositorioPuntos()
        {
            punto = LeerDatos();
        }



        public void AgregarPunto(Punto3D puntos)
        {
            punto!.Add(puntos);
        }

        public void EliminarPunto(Punto3D puntos)
        {
            punto!.Remove(puntos);
        }

        public bool Existe(Punto3D puntos)
        {
            return punto.Any(e => e.X == puntos.X &&
                e.Y == puntos.Y && e.Z == puntos.Z);
        }

        public List<Punto3D> ObtenerPuntos()
        {
            return new List<Punto3D>(punto);
        }

        public List<Punto3D>? OrdenarAsc()
        {
            return punto.OrderBy(e => e.CalcularDistancia()).ToList();
        }

        public List<Punto3D>? OrdenarDesc()
        {
            return punto.OrderByDescending(e => e.CalcularDistancia()).ToList();
        }
        private List<Punto3D>? LeerDatos()
        {
            var listaPuntos = new List<Punto3D>();
            rutaCompletaArchivo = Path.Combine(rutaProyecto, nombreArchivo);
            if (!File.Exists(rutaCompletaArchivo))
            {
                return listaPuntos;
            }
            using (var lector = new StreamReader(rutaCompletaArchivo))
            {
                while (!lector.EndOfStream)
                {
                    string? linea = lector.ReadLine();
                    Punto3D? punto = ConstruirPunto(linea);
                    listaPuntos.Add(punto!);
                }
            }
            return listaPuntos;
        }

        public void GuardarDatos()
        {
            rutaCompletaArchivo = Path.Combine(rutaProyecto, nombreArchivo);
            using (var escritor = new StreamWriter(rutaCompletaArchivo))
            {
                foreach (var puntos in punto)
                {
                    string linea = ConstruirLinea(puntos);
                    escritor.WriteLine(linea);
                }
            }
        }

        private string ConstruirLinea(Punto3D punto)
        {
            return $"{punto.X}|{punto.Y}||{punto.Z}|{punto.Color.GetHashCode()}|";
        }

        private Punto3D? ConstruirPunto(string? linea)
        {
            var campos = linea!.Split('|');
            var X = int.Parse(campos[0]);
            var Y = int.Parse(campos[1]);
            var Z = int.Parse(campos[2]);
            string color = (campos[3]);
            return new Punto3D(X,Y,Z,color);
        }
    }
}
