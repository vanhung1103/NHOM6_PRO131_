using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModel;
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
    public partial class Frm_BillDetail : Form
    {
        public Guid _idhdct;
        public IBillDetailServices _IbillDetailServices;
        public Frm_BillDetail()
        {
            InitializeComponent();
            _IbillDetailServices = new BillDetailServices();
        }
        public void LoadToGridView()
        {
            int stt = 1;
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 5;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã hóa đơn CT";
            dtg_show.Columns[3].Name = "Price";
            dtg_show.Columns[4].Name = "Quantity";
            dtg_show.Columns[5].Name = "Image";
            foreach (var item in _IbillDetailServices.Get())
            {
                dtg_show.Rows.Add(
                    item.Id,
                    stt++,
                    item.MaHDCT,
                    item.Price,
                    item.Quantity,
                    item.Image
                    );
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbx_mahd.Text == "")
            {
                tbx_mahd.BackColor = Color.Yellow;
                MessageBox.Show("Không để trống mã hóa đơn, vui lòng nhập mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BillDetailView billDetailView = new BillDetailView()
                {
                    MaHDCT = tbx_mahd.Text,
                    Price = Convert.ToInt32(tbx_price.Text),
                    Quantity = Convert.ToInt32(tbx_quantity.Text),
                    Image = tbx_image.Text,

                };
                DialogResult dg = MessageBox.Show("Bạn có muốn thêm ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_IbillDetailServices.Add(billDetailView));
                    LoadToGridView();
                }
            }
            LoadToGridView();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            BillDetailView billDetailView = new BillDetailView()
            {
                MaHDCT = tbx_mahd.Text,
                Price = Convert.ToInt32(tbx_price.Text),
                Quantity = Convert.ToInt32(tbx_quantity.Text),
                Image = tbx_image.Text,

            };
            DialogResult dg = MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IbillDetailServices.Update(billDetailView));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IbillDetailServices.Remove(_idhdct));
                LoadToGridView();
            }
            LoadToGridView();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idhdct = Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString());
            tbx_mahd.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            tbx_price.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            tbx_quantity.Text = dtg_show.CurrentRow.Cells[4].Value.ToString();
            tbx_image.Text = dtg_show.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
