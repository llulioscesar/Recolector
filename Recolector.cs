using System.Data;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace jcesar.co
{
    public class Recolector
    {
        private static Recolector datos;
        private Recolector() { }

        public static Recolector Instancia()
        {
            if (datos == null)
            {
                datos = new Recolector();
            }

            return datos;
        }
        public Frame Contenido { get; set; }
        public ToggleButton Atras { get; set; }
        public ListBox Menu { get; set; }
        public TextBlock Indicador { get; set; }
        public MySqlDataAdapter SqlAdaptador { get; set; }
        public DataSet DataSet { get; set; }
        public DataTable Tabla { get; set; }
        public List<object> Control { get; set; }
    }
}
