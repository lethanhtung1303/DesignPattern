using System.Windows.Forms;

namespace quanlyxekhach.CommandButton
{
    internal class ManageButtonDisable : CommandButtonManage
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