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
    public partial class frmStdPayments : Form
    {
        public frmStdPayments()
        {
            InitializeComponent();
        }

        private void frmStdPayments_Load(object sender, EventArgs e)
        {
            period();
            Totals();
            loadFeeStructure();
        }
        public void period()
        {
            string sql = "select top 1 * from period order by id desc ";
            DataTable dt = OpenTable.Query(sql);
            if (dt.Rows.Count > 0)
            {
                txtTerm.Text = dt.Rows[0][1].ToString();
                txtYear.Text = dt.Rows[0][2].ToString();
                txttTerm.Text = dt.Rows[0][1].ToString();
                txttYear.Text = dt.Rows[0][2].ToString();
            }
        }
        void Totals()
        {
            txtBF.Text = "0";
            string sql = "select SUM( cast(TermI as float)) as TermI,SUM( cast(TermII as float)) as TermII,SUM( cast(TermIII as float)) as TermII,( SUM( cast(TermI as float))+ SUM( cast(TermII as float))+ SUM( cast(TermIII as float)) ) as Totals,year from FeesStructure where YEAR='"+ txtYear.Text +"'  group by YEAR";
            DataTable dt = OpenTable.Query(sql);
            if (dt.Rows.Count > 0)
            {
                if (txtTerm.Text == "One")
                {
                    txtCurrentFee.Text =dt.Rows[0][0].ToString();
                }
                else if(txtTerm.Text == "Two")
                {
                     txtCurrentFee.Text =dt.Rows[0][1].ToString();
                }
                else if (txtTerm.Text == "Three")
                {
                     txtCurrentFee.Text =dt.Rows[0][2].ToString();
                }
                txtTotalY.Text = dt.Rows[0][3].ToString();
                txtTotalMonth.Text = (Convert.ToInt64(txtBF.Text) + Convert.ToInt64(txtCurrentFee.Text)).ToString();

               
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
            }
        }

        private void cmdPost_Click(object sender, EventArgs e)
        {
            string sql = "insert into FeePayments values('" + txtAdmno.Text + "','" + txttTerm.Text + "','" + txttYear.Text + "','" + txtClass.Text + "','" + txtDate.Text + "','"+ txtAmount.Text +"','" + txtMode.Text + "','" + txtReceipt.Text + "','" + txtPaidBy.Text + "')";
            OpenTable.NonQuery(sql);
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadFeeStructure();
           
        }
        void loadFeeStructure()
        {
            string sql = "select [Date],Amount,Receipt,MoP,paidBy from FeePayments where admno='" + txtAdmno.Text + "'";
            DataTable dt = OpenTable.Query(sql);
            int x = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                StudentsList.Items.Clear();
                for (int k = 0; k < x; k++)
                {
                    int mm = k + 1;
                    string m = mm.ToString();
                    ListViewItem lvi = new ListViewItem(m);

                    lvi.SubItems.Add(dt.Rows[k][0].ToString());
                    lvi.SubItems.Add(dt.Rows[k][1].ToString());
                    lvi.SubItems.Add(dt.Rows[k][2].ToString());
                    lvi.SubItems.Add(dt.Rows[k][4].ToString());
                    lvi.SubItems.Add(dt.Rows[k][3].ToString());
                    StudentsList.Items.Add(lvi);
                }
            }
        }
    }
}
