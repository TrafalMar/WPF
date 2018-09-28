using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Web.Classes
{

    [Serializable]
    public class Design
    {
      
        public void menu_btn_style(Button[] btn, Form form) {
            int but_count = 0;
            foreach (Button i in btn) {
                i.FlatStyle = FlatStyle.Flat;
                i.FlatAppearance.BorderSize = 0;
                i.Left = form.Size.Width-i.Width-i.Width*but_count;
                but_count += 1;
            }
        }
        public void search_btn_style(Button[] btn, Form form)
        {
            int but_count = 0;
            foreach (Button i in btn)
            {
                i.FlatStyle = FlatStyle.Flat;
                i.FlatAppearance.BorderSize = 0;
                i.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
                i.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240,240,240);
                i.Margin = new Padding(0);
                but_count += 1;
            }
        }

        public void search(TextBox[] text) {
            foreach (TextBox i in text) {
               
            }
        }

        
    }
}
