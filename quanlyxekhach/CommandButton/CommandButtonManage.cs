using System.Windows.Forms;

namespace quanlyxekhach.CommandButton
{
    internal abstract class CommandButtonManage
    {
        protected Button[] buttons;

        protected CommandButtonManage(params Button[] buttons)
        {
            this.buttons = buttons;
        }

        public abstract void Execute();
    }
}