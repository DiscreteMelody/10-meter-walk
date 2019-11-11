using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Meter_Walk
{
    public static class ConfirmationBox
    {
        /// <summary>
        /// Shows a Yes/No dialog box and returns true if yes is selected, otherwise false
        /// </summary>
        /// <param name="question_to_ask">The message the user will see</param>
        /// <returns></returns>
        public static bool ShowConfirmationScreen(string question_to_ask)
        {
            var confirm = MessageBox.Show(question_to_ask, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(confirm == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
