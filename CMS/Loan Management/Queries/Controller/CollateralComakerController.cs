using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CMS.Loan_Management.Reports.Controller
{
    class CollateralComakerController
    {
        Reports.Model.CollateralComakerModel collateralComakerModel;
        Reports.View.CollateralComaker collateralComaker;


        public CollateralComakerController(Reports.Model.CollateralComakerModel collateralComakerModel, Reports.View.CollateralComaker collateralComaker, int loanApplicationId) 
        {

            this.collateralComaker = collateralComaker;
            this.collateralComakerModel = collateralComakerModel;
            this.collateralComakerModel.loanApplicationId = loanApplicationId;
            this.collateralComaker.collateralGrid(this.collateralComakerModel.selectCollaterals());
            this.collateralComaker.comakerGrid(this.collateralComakerModel.selectComakers());
            collateralComaker.Show();
        
        
        }

    }
}
