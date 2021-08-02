using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulos.BL;

namespace Triangulos.DL
{
    public class RepositorioDeTriangulos
    {
        private string ArchivoDeDatos = Application.StartupPath + @"\Triangulos.txt";
        public List<Triangulo> ListaTriangulos { get; set; } = new List<Triangulo>();
        public bool EstaModificado { get; set; } = false;
        public void Agregar(Triangulo triangulo)
        {
            ListaTriangulos.Add(triangulo);
        }

        public void Borrar(Triangulo triangulo)
        {
            ListaTriangulos.Remove(triangulo);
        }
        public void GuardarDatosArchivo()
        {
            StreamWriter escritor = new StreamWriter(ArchivoDeDatos);
            foreach (var triangulo in ListaTriangulos)
            {
                var linea = $"{triangulo.Lado1};{triangulo.Lado2};{triangulo.Lado3}";
                escritor.WriteLine(linea);
            }
            escritor.Close();
        }

        public RepositorioDeTriangulos()
        {
            LeerDatosArchivo();
        }
        public void LeerDatosArchivo()
        {
            if (File.Exists(ArchivoDeDatos))
            {
                StreamReader lector = new StreamReader(ArchivoDeDatos);
                while (!lector.EndOfStream)
                {
                    var campos = lector.ReadLine().Split(';');
                    Triangulo triangulo = new Triangulo
                    {
                        Lado1 = int.Parse(campos[0]),
                        Lado2 = int.Parse(campos[1]),
                        Lado3 = int.Parse(campos[2])

                    };
                    ListaTriangulos.Add(triangulo);
                }
                lector.Close();
            }
        }
        public List<Triangulo> GetLista()
        {
            return ListaTriangulos;
        }

        public int GetCantidad()
        {
            return ListaTriangulos.Count();
        }

        public List<Triangulo> OrdenarporPerimetro()
        {
            return ListaTriangulos.OrderBy(r => r.GetPerimetro()).ToList();
        }

        public List<Triangulo> OrdenarporPerimetroDes()
        {
            return ListaTriangulos.OrderByDescending(r => r.GetPerimetro()).ToList();
        }
    }
}
