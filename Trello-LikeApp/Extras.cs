using System.Windows.Forms;

namespace Trello_LikeApp
{
    class Extras
    {
        private Control label2;
        private Control label1;
        private Control label4;
        private Control label5;
        private Control save_button;

        public Extras(Control label2, Control label1, Control label4,
            Control label5, Control save_button)
        {
            this.label2 = label2;
            this.label1 = label1;
            this.label4 = label4;
            this.label5 = label5;
            this.save_button = save_button;

        }
        public void ToolTips()
        {

            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 900;
            toolTip.ReshowDelay = 500;

            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;
            //toolTip.IsBalloon = true;

            // Set up the ToolTip text.
            toolTip.SetToolTip(label2, "Name of your Project");
            toolTip.SetToolTip(label1, "Name of your Project manager");
            toolTip.SetToolTip(label4, "Start Day of your project");
            toolTip.SetToolTip(label5, "Last Day of your project");
            toolTip.SetToolTip(save_button, "Saves all");
        }
    }
}
