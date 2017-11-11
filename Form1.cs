using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void insertFormDetails()
        {
            // Give the connection string here
            string connectionString = "Server = (localdb)\\MSSQLLocalDB; Initial Catalog = Sample; Integrated Security = true";
            SqlConnection connection = null;
            using(connection = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand("sp_salary",connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@empid", SqlDbType.BigInt).Value = Convert.ToInt64(empid.Text);
                    cmd.Parameters.Add("@month", SqlDbType.VarChar).Value = DateTime.Now.ToString("MMMM");
                    cmd.Parameters.Add("@year", SqlDbType.Int).Value = DateTime.Today.Year;
                    cmd.Parameters.Add("@pay", SqlDbType.Decimal).Value = Convert.ToDecimal(pay.Text);
                    cmd.Parameters.Add("@agp", SqlDbType.Decimal).Value = Convert.ToDecimal(agp.Text);
                    cmd.Parameters.Add("@DA", SqlDbType.Decimal).Value = Convert.ToDecimal(DA.Text);
                    cmd.Parameters.Add("@HRA", SqlDbType.Decimal).Value = Convert.ToDecimal(HRA.Text);
                    cmd.Parameters.Add("@TRA", SqlDbType.Decimal).Value = Convert.ToDecimal(TRA.Text);
                    cmd.Parameters.Add("@DAonTRA", SqlDbType.Decimal).Value = Convert.ToDecimal(DAonTRA.Text);
                    cmd.Parameters.Add("@FP", SqlDbType.Decimal).Value = Convert.ToDecimal(FP.Text);
                    cmd.Parameters.Add("@SP", SqlDbType.Decimal).Value = Convert.ToDecimal(SP.Text);
                    cmd.Parameters.Add("@WA", SqlDbType.Decimal).Value = Convert.ToDecimal(WA.Text);
                    cmd.Parameters.Add("@payandallowancesOthers", SqlDbType.Decimal).Value = Convert.ToDecimal(payandallowancesOthers.Text);
                    cmd.Parameters.Add("@GPF_CPF", SqlDbType.Decimal).Value = Convert.ToDecimal(GPF_CPF.Text);
                    cmd.Parameters.Add("@NPS", SqlDbType.Decimal).Value = Convert.ToDecimal(NPS.Text);
                    cmd.Parameters.Add("@NPSArrears", SqlDbType.Decimal).Value = Convert.ToDecimal(NPSArrears.Text);
                    cmd.Parameters.Add("@PFLOAN", SqlDbType.Decimal).Value = Convert.ToDecimal(PFLOAN.Text);
                    cmd.Parameters.Add("@GIS", SqlDbType.Decimal).Value = Convert.ToDecimal(GIS.Text);
                    cmd.Parameters.Add("@It", SqlDbType.Decimal).Value = Convert.ToDecimal(It.Text);
                    cmd.Parameters.Add("@EBF", SqlDbType.Decimal).Value = Convert.ToDecimal(EBF.Text);
                    cmd.Parameters.Add("@PT", SqlDbType.Decimal).Value = Convert.ToDecimal(PT.Text);
                    cmd.Parameters.Add("@LIC", SqlDbType.Decimal).Value = Convert.ToDecimal(LIC.Text);
                    cmd.Parameters.Add("@CCS", SqlDbType.Decimal).Value = Convert.ToDecimal(CCS.Text);
                    cmd.Parameters.Add("@HBA", SqlDbType.Decimal).Value = Convert.ToDecimal(HBA.Text);
                    cmd.Parameters.Add("@HDFC", SqlDbType.Decimal).Value = Convert.ToDecimal(HDFC.Text);
                    cmd.Parameters.Add("@MedicalAdv", SqlDbType.Decimal).Value = Convert.ToDecimal(MedicalAdv.Text);
                    cmd.Parameters.Add("@OR1C62", SqlDbType.Decimal).Value = Convert.ToDecimal(OR1C62.Text);
                    cmd.Parameters.Add("@MiscRecpt", SqlDbType.Decimal).Value = Convert.ToDecimal(MiscRecpt.Text);
                    cmd.Parameters.Add("@EOLHPLC_68_78", SqlDbType.Decimal).Value = Convert.ToDecimal(EOLHPLC_68_78.Text);
                    cmd.Parameters.Add("@FestivalAdv", SqlDbType.Decimal).Value = Convert.ToDecimal(FestivalAdv.Text);
                    cmd.Parameters.Add("@HouseRent", SqlDbType.Decimal).Value = Convert.ToDecimal(HouseRent.Text);
                    cmd.Parameters.Add("@WaterCharges", SqlDbType.Decimal).Value = Convert.ToDecimal(WaterCharges.Text);
                    cmd.Parameters.Add("@ElecCharges", SqlDbType.Decimal).Value = Convert.ToDecimal(ElecCharges.Text);
                    cmd.Parameters.Add("@Buscharges", SqlDbType.Decimal).Value = Convert.ToDecimal(Buscharges.Text);
                    cmd.Parameters.Add("@MCA", SqlDbType.Decimal).Value = Convert.ToDecimal(MCA.Text);
                    cmd.Parameters.Add("@CompAdv", SqlDbType.Decimal).Value = Convert.ToDecimal(CompAdv.Text);
                    cmd.Parameters.Add("@TutionFee", SqlDbType.Decimal).Value = Convert.ToDecimal(TutionFee.Text);
                    cmd.Parameters.Add("@LTCAdv", SqlDbType.Decimal).Value = Convert.ToDecimal(LTCAdv.Text);
                    cmd.Parameters.Add("@TeleCharges", SqlDbType.Decimal).Value = Convert.ToDecimal(TeleCharges.Text);
                    cmd.Parameters.Add("@deductionsOthers", SqlDbType.Decimal).Value = Convert.ToDecimal(deductionsOthers.Text);

                    netpay.Text = (Convert.ToDecimal(grosspay.Text) - Convert.ToDecimal(totaldeductions.Text)).ToString();

                    cmd.Parameters.Add("@grosspay", SqlDbType.Decimal).Value = Convert.ToDecimal(grosspay.Text);
                    cmd.Parameters.Add("@totaldeductions", SqlDbType.Decimal).Value = Convert.ToDecimal(totaldeductions.Text);
                    cmd.Parameters.Add("@netpay", SqlDbType.Decimal).Value = Convert.ToDecimal(netpay.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void assignTextBoxes()
        {
            grosspay.Text = calculateSumFromTextBox(new TextBox[] { pay, agp, DA, DA, TRA, DAonTRA, FP, SP, WA, payandallowancesOthers });
            totaldeductions.Text = calculateSumFromTextBox(new TextBox[] { GPF_CPF, NPS, NPSArrears, PFLOAN, GIS, It, EBF, PT, LIC, CCS, HBA, HDFC, MedicalAdv, OR1C62, MiscRecpt, EOLHPLC_68_78, FestivalAdv, HouseRent, WaterCharges, ElecCharges, Buscharges, MCA, CompAdv, TutionFee, LTCAdv, TeleCharges, deductionsOthers });
        }

        private string calculateSumFromTextBox(TextBox[] textBoxes)
        {
            Decimal sum = 0;
            foreach(TextBox tb in textBoxes)
            {
                sum += convertToDecimal(tb);
            }
            return sum.ToString();
        }

        private Decimal convertToDecimal(TextBox tb)
        {
            return Convert.ToDecimal(tb.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            assignTextBoxes();
            insertFormDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!empid.Text.Equals(""))
            {
                string connectionStr = "Server = (localdb)\\MSSQLLocalDB; Initial Catalog = Sample; Integrated Security = true";
                SqlConnection con = null;
                using(con =  new SqlConnection(connectionStr))
                {
                    DataSet ds = new DataSet();
                    SqlCommand cmd = new SqlCommand(null, con);
                    cmd.CommandText = "select * from mstemployees where empid = @empid";
                    SqlParameter param = new SqlParameter("@empid", SqlDbType.BigInt);
                    param.Value = Convert.ToInt16(empid.Text);
                    cmd.Parameters.Add(param);
                    con.Open();
                    cmd.Prepare();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    DataRow dr = dt.Rows[0];
                    name.Text = dr["name"].ToString();
                    designation.Text = dr["designation"].ToString();
                    department.Text = dr["department"].ToString();
                    pan.Text = dr["pan"].ToString();
                    bankname.Text = dr["bankname"].ToString();
                    bankaccountno.Text = dr["bankaccountno"].ToString();
                    ppfno.Text = dr["ppfno"].ToString();
                    ccsno.Text = dr["ccsno"].ToString();
                    payband.Text = dr["payband"].ToString();
                    con.Close();
                }
            }
        }
    }
}