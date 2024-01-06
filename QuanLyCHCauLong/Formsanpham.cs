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
    public partial class Frmsanpham : Form
    {
        public Frmsanpham()
        {
            InitializeComponent();
        }

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sanphamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sanphamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyCuaHangCauLongDataSet);

        }

        private void Frmsanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangCauLongDataSet.sanpham' table. You can move, or remove it, as needed.
            this.sanphamTableAdapter.Fill(this.quanLyCuaHangCauLongDataSet.sanpham);

        }

        private void sanphamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
