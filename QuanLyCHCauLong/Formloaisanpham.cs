using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHCauLong
{
    public partial class Frmloaisanpham : Form
    {
        public Frmloaisanpham()
        {
            InitializeComponent();
        }

        private void loaisanphamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loaisanphamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyCuaHangCauLongDataSet);

        }

        private void Formloaisanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangCauLongDataSet.loaisanpham' table. You can move, or remove it, as needed.
            this.loaisanphamTableAdapter.Fill(this.quanLyCuaHangCauLongDataSet.loaisanpham);

        }
    }
}
