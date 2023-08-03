using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_Supplier : Form
    {
        ISupplierServices supform;
        Supplier nhacungcaps;
        public Frm_Supplier()
        {
            InitializeComponent();
            supform = new SupplierServices();
            nhacungcaps = new Supplier();
        }
        void LoadData()
        {
            dtg_sup.Rows.Clear();
            dtg_sup.ColumnCount = 2;
            dtg_sup.Columns[0].Name = "Id";
            dtg_sup.Columns[1].Name = "Name";
            foreach (var x in supform.GetSuppliers())
            {
                dtg_sup.Rows.Add(x.Id, x.Name);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var them = new Supplier()
            {
                Id = Guid.NewGuid(),
                Name = txt_name.Text,
            };
            if (them.Name == nhacungcaps.Name)
            {
                MessageBox.Show("Da ton tai");
            }
            else
            {
                if (supform.AddSupplier(them) != null)
                {
                    LoadData();
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
                }
            }
        }

        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (nhacungcaps != null)
            {
                nhacungcaps.Name = txt_name.Text;
                supform.UpdateSupplier(nhacungcaps);
                LoadData();
                MessageBox.Show("Sua thanh cong", "Sua", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (nhacungcaps != null)
            {
                supform.DeleteSupplier(nhacungcaps.Id);
                LoadData();
                MessageBox.Show("Xoa thanh cong", "Xoa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = supform.GetSuppliers().Where(x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dtg_sup.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dtg_sup.Rows.Add(x.Id, x.Name);
            }
        }

        private void dtg_sup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (selectedRow >= 0 && selectedRow < dtg_sup.Rows.Count)
            {
                DataGridViewRow row = dtg_sup.Rows[selectedRow];
                var selectedId = Guid.Parse(row.Cells[0].Value.ToString());
                nhacungcaps = supform.GetSupplierID(selectedId);
                txt_name.Text = nhacungcaps.Name;
            }
        }
    }
}
