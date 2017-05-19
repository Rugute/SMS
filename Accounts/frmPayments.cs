using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sms.Accounts
{
    public partial class frmPayments : Form
    {
        public frmPayments()
        {
            InitializeComponent();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {

        }

        private void txtIdValue_TextChanged(object sender, EventArgs e)
        {
            string sql = "";
            if (txtSea.Text == "ADMNO")
            {
                sql = "select s.Admno,(s.surname+' '+s.othernames) as Names,Gender,class,stream,term,YEAR,status,BoardingType,dorm,EYOC from students s inner join nominal n on s.admno=n.admno where s.admno like'%" + txtIdValue.Text + "%'";
            }
            else if (txtSea.Text == "Name")
            {
                sql = "select s.Admno,(s.surname+' '+s.othernames) as Names,Gender,class,stream,term,YEAR,status,BoardingType,dorm,EYOC from students s inner join nominal n on s.admno=n.admno where (s.surname+' '+s.othernames) like '%" + txtIdValue.Text + "%'";

            }
            DataTable dtr = OpenTable.Query(sql);
            int xxx = dtr.Rows.Count;
            if (xxx > 0)
            {
                StudentsList.Items.Clear();

                for (int k = 0; k < xxx; k++)
                {
                    int mm = k + 1;
                    string m = mm.ToString();

                    ListViewItem lvi = new ListViewItem(m);
                    lvi.SubItems.Add(dtr.Rows[k][0].ToString());
                    lvi.SubItems.Add(dtr.Rows[k][1].ToString());
                    lvi.SubItems.Add(dtr.Rows[k][2].ToString());
                    lvi.SubItems.Add(dtr.Rows[k][3].ToString());
                    lvi.SubItems.Add(dtr.Rows[k][4].ToString());
                    lvi.SubItems.Add(dtr.Rows[k][5].ToString());
                    lvi.SubItems.Add(dtr.Rows[k][6].ToString());
                    lvi.SubItems.Add(dtr.Rows[k][7].ToString());
                    lvi.SubItems.Add(dtr.Rows[k][8].ToString());
                    lvi.SubItems.Add(dtr.Rows[k][9].ToString());
                    lvi.SubItems.Add(dtr.Rows[k][10].ToString());
                    StudentsList.Items.Add(lvi);


                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
            }
        }

        private void StudentsList_MouseClick(object sender, MouseEventArgs e)
        {
            frmStdPayments x = new frmStdPayments();
            x.txtAdmno.Text = StudentsList.SelectedItems[0].SubItems[1].Text;
            x.txtName.Text = StudentsList.SelectedItems[0].SubItems[2].Text;
            x.txtClass.Text = StudentsList.SelectedItems[0].SubItems[4].Text;
            x.ShowDialog();
        }
    }
}
