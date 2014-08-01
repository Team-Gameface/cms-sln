using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Savings.Maintenance.Model
{
    class MemberSavingsTypeModel
    {
        public int AccountTypeId { get; set; }
        public int MemberTypeNo { get; set; }

        public MemberSavingsTypeModel()
        {
            this.AccountTypeId = 0;
            this.MemberTypeNo = 0;
        }
    }
}
