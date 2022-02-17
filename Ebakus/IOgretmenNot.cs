using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Ebakus
{
    public interface IOgretmenNot
    {
        void notGoster(DataGridView dataGridView1, string sinif);
        void notGuncelle(string[] notlar, string numara);
    }
}
