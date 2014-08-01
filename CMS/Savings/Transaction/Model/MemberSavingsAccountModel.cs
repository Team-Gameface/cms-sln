using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Savings.Transaction.Model
{
    public class MemberSavingsAccountModel
    {
        public String MemberAccountNo { get; set; }
        public String SavingsAccountNo { get; set; }

        public MemberSavingsAccountModel()
        {
            this.MemberAccountNo = String.Empty;
            this.SavingsAccountNo = String.Empty;
        }
    }
}
