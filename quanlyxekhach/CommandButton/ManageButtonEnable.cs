using System.Windows.Forms;

namespace quanlyxekhach.CommandButton
{
    internal class ManageButtonEnable : CommandButtonManage
    {
        public ManageButtonEnable(params Button[] buttons) : base(buttons)
        {
        }

        public override void Execute()
        {
            foreach (var button in buttons)
            {
                button.Enabled = true;
            }
        }
    }
}