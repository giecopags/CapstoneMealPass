using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CapstoneMealPass.Helpers
{
    public class FormHelper
    {
        public static async Task LoadUserControlAsync(SidePanel targetPanel, Func<UserControl> controlFactory)
        {

            var controlToLoad = await Task.Run(controlFactory);

            targetPanel.Controls.Clear();
            controlToLoad.Dock = DockStyle.Fill;
            targetPanel.Controls.Add(controlToLoad);
        }

        public static void DisplayForm(Form targetForm)
        {
            targetForm.Show();
        }

        public static async Task LoadUserControl(SidePanel targetPanel, Func<UserControl> controlFactory)
        {    
            await Task.Yield(); 

            var controlToLoad = controlFactory(); 

            targetPanel.Controls.Clear();
            controlToLoad.Dock = DockStyle.Fill;
            targetPanel.Controls.Add(controlToLoad);
        }
    }
}
