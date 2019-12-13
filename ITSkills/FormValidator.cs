using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSkills
{
    class FormValidator
    {
        /*public static bool IsValidated(Form form, ErrorProvider errorProvider)
        {
            foreach (Control component in form.Controls)
            {
                Console.WriteLine(component.Name);
                if (!String.IsNullOrEmpty(errorProvider.GetError(component)))
                {
                    return false;
                }
            }
            return true;
        }*/

        public static bool IsValidated(Control parent, ErrorProvider errorProvider)
        {
            Console.WriteLine(parent.Name);
            if (!String.IsNullOrEmpty(errorProvider.GetError(parent)))
            {
                return false;
            }
            else
            {
                foreach (Control ctrl in parent.Controls)
                {
                    if (!IsValidated(ctrl, errorProvider))
                        return false;
                }
            }
            return true;
        }
    }
}
