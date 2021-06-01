using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTools
{
    public partial class FormDashboard : Form
    {
        #region Declare User Controls
        UserControls.Network.UCIPGeoLocation ucIPGeoLocation = new UserControls.Network.UCIPGeoLocation();
        UserControls.Network.UCIPHeader ucIPHeader = new UserControls.Network.UCIPHeader();
        UserControls.Network.UCPing ucPing = new UserControls.Network.UCPing();
        UserControls.Network.UCTraceRoute ucTraceRoute = new UserControls.Network.UCTraceRoute();
        UserControls.Misc.UCBase64 ucBase64 = new UserControls.Misc.UCBase64();
        UserControls.Misc.UCBinaryConverter ucBinaryConverter = new UserControls.Misc.UCBinaryConverter();
        UserControls.Misc.UCSIDConverter ucSIDConverter = new UserControls.Misc.UCSIDConverter();
        UserControls.UCHome ucHome = new UserControls.UCHome();
        UserControls.UCSetting ucSetting = new UserControls.UCSetting();
        #endregion

        // Constructor
        public FormDashboard()
        {
            InitializeComponent();
        }

        #region Methods
        private void ActivateDesktopPanel(Control userControl)
        {
            if (userControl != null)
            {
                panelDesktop.Controls.Clear();
                panelDesktop.Controls.Add((Control)userControl);
            }
        }
        private void HidePanel(Panel panel)
        {
            if (panel != null)
            {
                if (panel.Visible == true)
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }
        }
        #endregion

        #region User interaction

        // Click logo
        private void pictureLogo_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucHome);
        }

        #region Network functions
        private void buttonNetwork_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucHome);
            HidePanel(panelNetwork);
        }

        private void buttonIPHeader_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucIPHeader);
        }

        private void buttonIPGeoLocation_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucIPGeoLocation);
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucPing);
        }

        private void buttonTraceRoute_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucTraceRoute);
        }

        #endregion End network

        #region Misc functions
        private void buttonMisc_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucHome);
            HidePanel(panelMisc);
        }

        private void buttonBase64_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucBase64);
        }

        private void buttonBinaryConverter_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucBinaryConverter);
        }

        private void buttonSIDConverter_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucSIDConverter);
        }
        #endregion End misc

        // Setting
        private void buttonSetting_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucSetting);
        }

        #endregion End user interaction

    }
}
