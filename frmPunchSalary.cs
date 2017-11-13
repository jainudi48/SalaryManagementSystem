using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmPunchSalary : Form
    {
        Decimal daPercent = 132, hraPercent = 30, daOnTraPercent = 132;
        const string employeeTypeNR = "NR";
        const string employeeTypeR = "R";
        const string employeeTypeNA = "NA";
        string employeeType = "";
        Decimal grossPaySum = 0, totalDeductionSum = 0, netPaySum = 0;
        public frmPunchSalary()
        {
            InitializeComponent();
        }

        private void frmPunchSalary_Load(object sender, EventArgs e)
        {
            gbSalary.Text = "Salary for the month of " + DateTime.Now.Month + "-" + DateTime.Now.Year.ToString();
            setFormulaLabel();
        }

        private void setFormulaLabel()
        {
            string conStr = "Server = (localdb)\\MSSQLLocalDB; Initial Catalog = Sample; Integrated Security = true";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_getFormulas", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@dapercent", SqlDbType.BigInt);
                    cmd.Parameters.Add("@hrapercent", SqlDbType.BigInt);
                    cmd.Parameters.Add("@daontrapercent", SqlDbType.BigInt);
                    cmd.Parameters["@dapercent"].Direction = ParameterDirection.Output;
                    cmd.Parameters["@hrapercent"].Direction = ParameterDirection.Output;
                    cmd.Parameters["@daontrapercent"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    lblFormula.Text = "Formulas:- DA:" + cmd.Parameters["@dapercent"].Value.ToString() + "% of PAY and GRADEPAY; HRA:" + cmd.Parameters["@hrapercent"].Value.ToString() + "% of PAY and GRADEPAY; DA on TRA:" + cmd.Parameters["@daontrapercent"].Value.ToString() + "% of TRA";
                }
            }
        }

        private void insertFormDetails()
        {
            // Give the connection string here
            string connectionString = "Server = (localdb)\\MSSQLLocalDB; Initial Catalog = Sample; Integrated Security = true";
            SqlConnection connection = null;
            using (connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_salary", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        cmd.Parameters.Add("@empid", SqlDbType.BigInt).Value = Convert.ToInt64(txtEmpID.Text);
                        cmd.Parameters.Add("@month", SqlDbType.VarChar).Value = DateTime.Now.ToString("MMMM");
                        cmd.Parameters.Add("@year", SqlDbType.Int).Value = DateTime.Today.Year;
                        try
                        {
                            cmd.Parameters.Add("@pay", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPay.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@pay", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@agp", SqlDbType.Decimal).Value = Convert.ToDecimal(txtAgp.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@agp", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@DA", SqlDbType.Decimal).Value = Convert.ToDecimal(txtDa.Text);

                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@DA", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@HRA", SqlDbType.Decimal).Value = Convert.ToDecimal(txtHra.Text);

                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@HRA", SqlDbType.Decimal).Value = 0;
                        }

                        try
                        {
                            cmd.Parameters.Add("@TRA", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTra.Text);

                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@TRA", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@DAonTRA", SqlDbType.Decimal).Value = Convert.ToDecimal(txtDaOnTra.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@DAonTRA", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@FP", SqlDbType.Decimal).Value = Convert.ToDecimal(txtFp.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@FP", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@SP", SqlDbType.Decimal).Value = Convert.ToDecimal(txtSp.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@SP", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@WA", SqlDbType.Decimal).Value = Convert.ToDecimal(txtWa.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@WA", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@payandallowancesOthers", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPayAndAllowancesOthers.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@payandallowancesOthers", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@GPF_CPF", SqlDbType.Decimal).Value = Convert.ToDecimal(txtGpfCpf.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@GPF_CPF", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@NPS", SqlDbType.Decimal).Value = Convert.ToDecimal(txtNps.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@NPS", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@NPSArrears", SqlDbType.Decimal).Value = Convert.ToDecimal(txtNpsArrears.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@NPSArrears", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@PFLOAN", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPfLoans.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@PFLOAN", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@GIS", SqlDbType.Decimal).Value = Convert.ToDecimal(txtGis.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@GIS", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@It", SqlDbType.Decimal).Value = Convert.ToDecimal(txtIt.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@It", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@EBF", SqlDbType.Decimal).Value = Convert.ToDecimal(txtEbf.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@EBF", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@PT", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPt.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@PT", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@LIC", SqlDbType.Decimal).Value = Convert.ToDecimal(txtLic.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@LIC", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@CCS", SqlDbType.Decimal).Value = Convert.ToDecimal(txtCcs.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@CCS", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@HBA", SqlDbType.Decimal).Value = Convert.ToDecimal(txtHba.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@HBA", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@HDFC", SqlDbType.Decimal).Value = Convert.ToDecimal(txtHdfc.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@HDFC", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@MedicalAdv", SqlDbType.Decimal).Value = Convert.ToDecimal(txtMedicalAdv.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@MedicalAdv", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@OR1C62", SqlDbType.Decimal).Value = Convert.ToDecimal(txtOR1C62.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@OR1C62", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@MiscRecpt", SqlDbType.Decimal).Value = Convert.ToDecimal(txtMiscRecpt.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@MiscRecpt", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@EOLHPLC_68_78", SqlDbType.Decimal).Value = Convert.ToDecimal(txtEOLHPLC_68_78.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@EOLHPLC_68_78", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@FestivalAdv", SqlDbType.Decimal).Value = Convert.ToDecimal(txtFestivalAdv.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@FestivalAdv", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@HouseRent", SqlDbType.Decimal).Value = Convert.ToDecimal(txtHouseRent.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@HouseRent", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@WaterCharges", SqlDbType.Decimal).Value = Convert.ToDecimal(txtWaterCharges.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@WaterCharges", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@ElecCharges", SqlDbType.Decimal).Value = Convert.ToDecimal(txtElecCharges.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@ElecCharges", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@Buscharges", SqlDbType.Decimal).Value = Convert.ToDecimal(txtBusCharges.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@Buscharges", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@MCA", SqlDbType.Decimal).Value = Convert.ToDecimal(txtMca.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@MCA", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@CompAdv", SqlDbType.Decimal).Value = Convert.ToDecimal(txtCompAdv.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@CompAdv", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@TutionFee", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTutionFee.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@TutionFee", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@LTCAdv", SqlDbType.Decimal).Value = Convert.ToDecimal(txtLtcAdv.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@LTCAdv", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@TeleCharges", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTeleCharges.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@TeleCharges", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@deductionsOthers", SqlDbType.Decimal).Value = Convert.ToDecimal(txtDeductionsOthers.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@deductionsOthers", SqlDbType.Decimal).Value = 0;
                        }

                        txtNetPay.Text = (Convert.ToDecimal(txtGrossPay.Text) - Convert.ToDecimal(txtTotalDeductions.Text)).ToString();

                        try
                        {
                            cmd.Parameters.Add("@grosspay", SqlDbType.Decimal).Value = Convert.ToDecimal(txtGrossPay.Text);
                        }
                        catch (Exception)
                        {
                            
                            cmd.Parameters.Add("@grosspay", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@totaldeductions", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotalDeductions.Text);
                        }
                        catch (Exception)
                        {

                            cmd.Parameters.Add("@totaldeductions", SqlDbType.Decimal).Value = 0;
                        }
                        try
                        {
                            cmd.Parameters.Add("@netpay", SqlDbType.Decimal).Value = Convert.ToDecimal(txtNetPay.Text);
                        }
                        catch (Exception)
                        {

                            cmd.Parameters.Add("@netpay", SqlDbType.Decimal).Value = 0 ;
                        }

                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show("Field contains an invalid or empty value!");
                        return;
                    }
                    
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    connection.Close();
                }
            }
        }

        private void assignTextBoxes()
        {
            txtGrossPay.Text = calculateSumFromTextBox(new TextBox[] { txtPay, txtAgp, txtDa, txtDa, txtTra, txtDaOnTra, txtFp, txtSp, txtWa, txtPayAndAllowancesOthers });
            txtTotalDeductions.Text = calculateSumFromTextBox(new TextBox[] { txtGpfCpf, txtNps, txtNpsArrears, txtPfLoans, txtGis, txtIt, txtEbf, txtPt, txtLic, txtCcs, txtHba, txtHdfc, txtMedicalAdv, txtOR1C62, txtMiscRecpt, txtEOLHPLC_68_78, txtFestivalAdv, txtHouseRent, txtWaterCharges, txtElecCharges, txtBusCharges, txtMca, txtCompAdv, txtTutionFee, txtLtcAdv, txtTeleCharges, txtDeductionsOthers });
        }

        private string calculateSumFromTextBox(TextBox[] textBoxes)
        {
            Decimal sum = 0;
            foreach (TextBox tb in textBoxes)
            {
                sum += convertToDecimal(tb);
            }
            return sum.ToString();
        }

        private Decimal convertToDecimal(TextBox tb)
        {
            Decimal decValue = 0;
            try
            {
                decValue = Convert.ToDecimal(tb.Text);
            }
            catch (Exception e)
            {

            }
            return decValue;
        }

        private void resetTextBoxes()
        {
            txtPay.Enabled = false;
            txtAgp.Enabled = false;
            txtDa.Enabled = false;
            txtHra.Enabled = false;
            txtTra.Enabled = false;
            txtDaOnTra.Enabled = false;
            txtFp.Enabled = false;
            txtSp.Enabled = false;
            txtWa.Enabled = false;
            txtPayAndAllowancesOthers.Enabled = false;

            txtGpfCpf.Enabled = false;
            txtNps.Enabled = false;
            txtNpsArrears.Enabled = false;
            txtPfLoans.Enabled = false;
            txtGis.Enabled = false;
            txtIt.Enabled = false;
            txtEbf.Enabled = false;
            txtPt.Enabled = false;
            txtLic.Enabled = false;
            txtCcs.Enabled = false;
            txtHba.Enabled = false;
            txtHdfc.Enabled = false;
            txtMedicalAdv.Enabled = false;
            txtOR1C62.Enabled = false;
            txtMiscRecpt.Enabled = false;
            txtEOLHPLC_68_78.Enabled = false;
            txtFestivalAdv.Enabled = false;
            txtHouseRent.Enabled = false;
            txtWaterCharges.Enabled = false;
            txtElecCharges.Enabled = false;
            txtBusCharges.Enabled = false;
            txtMca.Enabled = false;
            txtCompAdv.Enabled = false;
            txtTutionFee.Enabled = false;
            txtLtcAdv.Enabled = false;
            txtTeleCharges.Enabled = false;
            txtDeductionsOthers.Enabled = false;

            txtPay.Text = "";
            txtAgp.Text = "";
            txtDa.Text = "";
            txtHra.Text = "";
            txtTra.Text = "";
            txtDaOnTra.Text = "";
            txtFp.Text = "";
            txtSp.Text = "";
            txtWa.Text = "";
            txtPayAndAllowancesOthers.Text = "";

            txtGpfCpf.Text = "";
            txtNps.Text = "";
            txtNpsArrears.Text = "";
            txtPfLoans.Text = "";
            txtGis.Text = "";
            txtIt.Text = "";
            txtEbf.Text = "";
            txtPt.Text = "";
            txtLic.Text = "";
            txtCcs.Text = "";
            txtHba.Text = "";
            txtHdfc.Text = "";
            txtMedicalAdv.Text = "";
            txtOR1C62.Text = "";
            txtMiscRecpt.Text = "";
            txtEOLHPLC_68_78.Text = "";
            txtFestivalAdv.Text = "";
            txtHouseRent.Text = "";
            txtWaterCharges.Text = "";
            txtElecCharges.Text = "";
            txtBusCharges.Text = "";
            txtMca.Text = "";
            txtCompAdv.Text = "";
            txtTutionFee.Text = "";
            txtLtcAdv.Text = "";
            txtTeleCharges.Text = "";
            txtDeductionsOthers.Text = "";


        }

        private void resetEmployeeDetailsTextBoxes()
        {
            txtName.Text = "";
            txtDesignation.Text = "";
            txtDepartment.Text = "";
            txtPan.Text = "";
            txtBankName.Text = "";
            txtBankAccountNo.Text = "";
            txtPpfNo.Text = "";
            txtCcsNo.Text = "";
            txtPayBand.Text = "";
        }

        private void setTextBoxStatusFromEmpType(string dr)
        {
            if (dr == null)
                return;
            setEmployeeType(dr);
            if (employeeType.Equals(employeeTypeNR))
            {
                txtPay.Enabled = true;
                txtAgp.Enabled = true;
                txtTra.Enabled = true;
                txtSp.Enabled = true;
                txtGpfCpf.Enabled = true;
                txtPfLoans.Enabled = true;
                txtGis.Enabled = true;
                txtIt.Enabled = true;
                txtPt.Enabled = true;
                txtCcs.Enabled = true;
                txtMedicalAdv.Enabled = true;
            }
            if (employeeType.Equals(employeeTypeR))
            {
                txtPay.Enabled = true;
                txtAgp.Enabled = true;
                txtHra.Text = "0";

                txtTra.Enabled = true;
                txtSp.Enabled = true;
                txtGpfCpf.Enabled = true;
                txtGis.Enabled = true;
                txtIt.Enabled = true;
                txtEbf.Enabled = true;
                txtPt.Enabled = true;
                txtCcs.Enabled = true;
                txtHouseRent.Enabled = true;
                txtWaterCharges.Enabled = true;
                txtElecCharges.Enabled = true;
            }
            if (employeeType.Equals(employeeTypeNA))
            {
                txtPay.Enabled = true;
                txtSp.Enabled = true;
                txtIt.Enabled = true;
                txtPt.Enabled = true;
                txtCcs.Enabled = true;

            }
        }

        private void setDAandHRA()
        {
            if (!txtPay.Text.Equals("") && !txtAgp.Text.Equals(""))
            {
                if (!employeeType.Equals(employeeTypeR))
                {
                    txtHra.Text = ((hraPercent / 100) * (Convert.ToDecimal(txtPay.Text) + Convert.ToDecimal(txtAgp.Text))).ToString();
                }
                txtDa.Text = ((daPercent / 100) * (Convert.ToDecimal(txtPay.Text) + Convert.ToDecimal(txtAgp.Text))).ToString();
            }
            else
            {
                if (!employeeType.Equals(employeeTypeR))
                {
                    txtHra.Text = "";
                }
                txtDa.Text = "";
            }
        }

        private void setDAonTRA()
        {
            if (!txtTra.Text.Equals(""))
            {
                txtDaOnTra.Text = ((daOnTraPercent / 100) * (Convert.ToDecimal(txtTra.Text))).ToString();
            }
            else
            {
                txtDaOnTra.Text = "";
            }
        }

        private void setEmployeeType(string empType)
        {
            employeeType = empType;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            assignTextBoxes();
            insertFormDetails();
        }

        private void btnFetchDetails_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
            resetEmployeeDetailsTextBoxes();
            if (!txtEmpID.Text.Equals(""))
            {
                string connectionStr = "Server = (localdb)\\MSSQLLocalDB; Initial Catalog = Sample; Integrated Security = true";
                SqlConnection con = null;
                using (con = new SqlConnection(connectionStr))
                {
                    DataSet ds = new DataSet();
                    SqlCommand cmd = new SqlCommand(null, con);
                    cmd.CommandText = "select * from mstemployees where empid = @empid";
                    SqlParameter param = new SqlParameter("@empid", SqlDbType.BigInt);
                    param.Value = Convert.ToInt64(txtEmpID.Text);
                    cmd.Parameters.Add(param);
                    con.Open();
                    cmd.Prepare();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count < 1)
                    {
                        return;
                    }
                    DataRow dr = dt.Rows[0];

                    txtName.Text = dr["name"].ToString();
                    txtDesignation.Text = dr["designation"].ToString();
                    txtDepartment.Text = dr["department"].ToString();
                    txtPan.Text = dr["pan"].ToString();
                    txtBankName.Text = dr["bankname"].ToString();
                    txtBankAccountNo.Text = dr["bankaccountno"].ToString();
                    txtPpfNo.Text = dr["ppfno"].ToString();
                    txtCcsNo.Text = dr["ccsno"].ToString();
                    txtPayBand.Text = dr["payband"].ToString();
                    
                    txtPay.Text = dr["pay"].ToString();
                    txtAgp.Text = dr["gradepay"].ToString();

                    setDAandHRA();

                    if (dr["employeetype"] != null)
                    {
                        setTextBoxStatusFromEmpType(dr["employeetype"].ToString());
                    }

                    con.Close();

                    pnlPayAndAllowances.Enabled = true;
                    pnlDeductions.Enabled = true;
                    pnlNetPay.Enabled = true;
                    btnSubmit.Enabled = true;
                }
            }
        }

        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // FOR EMPID TEXTBOX ONLY
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtElecCharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDaOnTra_Leave(object sender, EventArgs e)
        {
            string nameOfTB = (sender as TextBox).Name;
            if (nameOfTB.Equals("txtPay") || nameOfTB.Equals("txtAgp"))
            {
                setDAandHRA();
            }
            if (nameOfTB.Equals("txtTra"))
            {
                setDAonTRA();
            }
            txtGrossPay.Text = calculateSumFromTextBox(new TextBox[] { txtPay, txtAgp, txtDa, txtHra, txtTra, txtDaOnTra, txtFp, txtSp, txtWa, txtPayAndAllowancesOthers });
            grossPaySum = Convert.ToDecimal(txtGrossPay.Text);
            netPaySum = grossPaySum - totalDeductionSum;
            txtNetPay.Text = netPaySum.ToString();
        }

        private void txtOR1C62_Leave(object sender, EventArgs e)
        {
            txtTotalDeductions.Text = calculateSumFromTextBox(new TextBox[] { txtGpfCpf, txtNps, txtNpsArrears, txtPfLoans, txtGis, txtIt, txtEbf, txtPt, txtLic, txtCcs, txtHba, txtHdfc, txtMedicalAdv, txtOR1C62, txtMiscRecpt, txtEOLHPLC_68_78, txtFestivalAdv, txtHouseRent, txtWaterCharges, txtElecCharges, txtBusCharges, txtMca, txtCompAdv, txtTutionFee, txtLtcAdv, txtTeleCharges, txtDeductionsOthers });
            totalDeductionSum = Convert.ToDecimal(txtTotalDeductions.Text);
            netPaySum = grossPaySum - totalDeductionSum;
            txtNetPay.Text = netPaySum.ToString();
        }

        private void btnChangeResidentialStatus_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
            string residentialStatus = txtResidentialStatus.Text.ToUpper().Trim();
            if (residentialStatus.Equals(employeeTypeR) || residentialStatus.Equals(employeeTypeNR) || residentialStatus.Equals(employeeTypeNA))
            {
                setTextBoxStatusFromEmpType(residentialStatus);
            }
        }



    }
}
