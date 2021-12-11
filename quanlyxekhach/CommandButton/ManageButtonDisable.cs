using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyxekhach.CommandButton
{
    class ManageButtonDisable: CommandButtonManage
    {
        public ManageButtonDisable(params Button[] buttons) : base(buttons)
        {

        }
        public override void Execute()
        {

            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
        }
    }
}
