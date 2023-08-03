using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Size = _1_DAL.Models.Size;

namespace _3_PL.Views
{
    public partial class Frm_Size : Form
    {
        ISizeServices sizeform;
        Size kichcos;
        public Frm_Size()
        {
            InitializeComponent();
            sizeform = new SizeServices();
            kichcos = new Size();
        }
        void LoadData()
        {
            dtg_size.Rows.Clear();
            dtg_size.ColumnCount = 2;
            dtg_size.Columns[0].Name = "Id";
            dtg_size.Columns[1].Name = "Name";
            foreach (var x in sizeform.GetSizes())
            {
                dtg_size.Rows.Add(x.Id, x.Name);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var them = new Size()
            {
                Id = Guid.NewGuid(),
                Name = txt_name.Text,
            };
            if (them.Name == kichcos.Name)
            {
                MessageBox.Show("Da ton tai");
            }
            else
            {
                if (sizeform.AddSize(them) != null)
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

        private void Frm_Size_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (kichcos != null)
            {
                kichcos.Name = txt_name.Text;
                sizeform.UpdateSize(kichcos);
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
            if (kichcos != null)
            {
                sizeform.DeleteSize(kichcos.Id);
                LoadData();
                MessageBox.Show("Xoa thanh cong", "Xoa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
            }
        }

        private void dtg_size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (selectedRow >= 0 && selectedRow < dtg_size.Rows.Count)
            {
                DataGridViewRow row = dtg_size.Rows[selectedRow];
                var selectedId = Guid.Parse(row.Cells[0].Value.ToString());
                kichcos = sizeform.GetSizeID(selectedId);
                txt_name.Text = kichcos.Name;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = sizeform.GetSizes().Where(x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dtg_size.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dtg_size.Rows.Add(x.Id, x.Name);
            }
        }
    }
}
