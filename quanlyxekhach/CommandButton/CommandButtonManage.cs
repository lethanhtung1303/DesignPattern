using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyxekhach.CommandButton
{

    abstract class CommandButtonManage
    {
        protected Button[] buttons;
        protected CommandButtonManage(params Button[] buttons)
        {
            this.buttons = buttons;
        }
        public abstract void Execute();
    }
}
