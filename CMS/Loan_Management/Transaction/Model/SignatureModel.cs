using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Loan_Management.Transaction.Model
{
    class SignatureModel
    {
        public byte[] signature { get; set; }

        public SignatureModel() {

            this.signature = null;
        }
    }
}
