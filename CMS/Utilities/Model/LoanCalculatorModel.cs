using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace CMS.Utilities.Model
{
    class LoanCalculatorModel
    {
        public String selectInterestRate(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(InterestRateValue,' ',InterestRateStatus,' ',Per) as 'Interest Rate' from LOAN_INTEREST_RATE where isArchived = 0 and loanTypeId =" + "'" + loanTypeId + "'";
            String interest = Convert.ToString(dal.executeScalar(sql));
            dal.Close();
            return interest;
        }

        public double selectCharges(int LoanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT sum(c.Amount) from CHARGES c INNER JOIN LOAN_TYPE_CHARGES ltc on c.ChargeId = ltc.ChargeId AND c.Status=1 AND c.isArchived=0 AND ltc.LoanTypeId = "+"'"+LoanTypeId+"'";
            Double charges = Convert.ToDouble(dal.executeScalar(sql));
            dal.Close();
            return charges;
        }

        public String selectPaymentDuration(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(MinimumPaymentDuration,' ',MinPDStatus,' to ',MaximumPaymentDuration,' ',MaxPDStatus) from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            String pd = Convert.ToString(dal.executeScalar(sql));
            dal.Close();
            return pd;
        }

        public DataSet selectLoanType()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_TYPE.LoanTypeId as 'LoanTypeId', LOAN_TYPE.LoanTypeName as 'LoanTypeName' from LOAN_TYPE, LOAN_INTEREST_RATE WHERE LOAN_TYPE.LoanTypeId = LOAN_INTEREST_RATE.LoanTypeId and LOAN_INTEREST_RATE.isArchived = 0 and Loan_Type.isArchived=0 and Loan_Type.Status=1 order by LOAN_TYPE.LoanTypeName";
            DataSet ds = dal.executeDataSet(sql);
            dal.Close();
            return ds;
        }
    }
}
