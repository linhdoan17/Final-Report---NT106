
namespace NetTools
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.panelMisc = new System.Windows.Forms.Panel();
            this.buttonSIDConverter = new System.Windows.Forms.Button();
            this.buttonBinaryConverter = new System.Windows.Forms.Button();
            this.buttonBase64 = new System.Windows.Forms.Button();
            this.buttonMisc = new System.Windows.Forms.Button();
            this.panelNetwork = new System.Windows.Forms.Panel();
            this.buttonTraceRoute = new System.Windows.Forms.Button();
            this.buttonPing = new System.Windows.Forms.Button();
            this.buttonIPGeoLocation = new System.Windows.Forms.Button();
            this.buttonIPHeader = new System.Windows.Forms.Button();
            this.buttonNetwork = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelMisc.SuspendLayout();
            this.panelNetwork.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.buttonSetting);
            this.panelMenu.Controls.Add(this.panelMisc);
            this.panelMenu.Controls.Add(this.buttonMisc);
            this.panelMenu.Controls.Add(this.panelNetwork);
            this.panelMenu.Controls.Add(this.buttonNetwork);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 687);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Location = new System.Drawing.Point(0, 408);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonSetting.Size = new System.Drawing.Size(165, 37);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.Text = "Setting";
            this.buttonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // panelMisc
            // 
            this.panelMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panelMisc.Controls.Add(this.buttonSIDConverter);
            this.panelMisc.Controls.Add(this.buttonBinaryConverter);
            this.panelMisc.Controls.Add(this.buttonBase64);
            this.panelMisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMisc.Location = new System.Drawing.Point(0, 310);
            this.panelMisc.Margin = new System.Windows.Forms.Padding(2);
            this.panelMisc.Name = "panelMisc";
            this.panelMisc.Size = new System.Drawing.Size(165, 98);
            this.panelMisc.TabIndex = 5;
            // 
            // buttonSIDConverter
            // 
            this.buttonSIDConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSIDConverter.FlatAppearance.BorderSize = 0;
            this.buttonSIDConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSIDConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSIDConverter.Location = new System.Drawing.Point(0, 64);
            this.buttonSIDConverter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSIDConverter.Name = "buttonSIDConverter";
            this.buttonSIDConverter.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buttonSIDConverter.Size = new System.Drawing.Size(165, 32);
            this.buttonSIDConverter.TabIndex = 3;
            this.buttonSIDConverter.Text = "SID Converter";
            this.buttonSIDConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSIDConverter.UseVisualStyleBackColor = true;
            this.buttonSIDConverter.Click += new System.EventHandler(this.buttonSIDConverter_Click);
            // 
            // buttonBinaryConverter
            // 
            this.buttonBinaryConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBinaryConverter.FlatAppearance.BorderSize = 0;
            this.buttonBinaryConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBinaryConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBinaryConverter.Location = new System.Drawing.Point(0, 32);
            this.buttonBinaryConverter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBinaryConverter.Name = "buttonBinaryConverter";
            this.buttonBinaryConverter.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buttonBinaryConverter.Size = new System.Drawing.Size(165, 32);
            this.buttonBinaryConverter.TabIndex = 2;
            this.buttonBinaryConverter.Text = "Binary Converter";
            this.buttonBinaryConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBinaryConverter.UseVisualStyleBackColor = true;
            this.buttonBinaryConverter.Click += new System.EventHandler(this.buttonBinaryConverter_Click);
            // 
            // buttonBase64
            // 
            this.buttonBase64.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBase64.FlatAppearance.BorderSize = 0;
            this.buttonBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBase64.Location = new System.Drawing.Point(0, 0);
            this.buttonBase64.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBase64.Name = "buttonBase64";
            this.buttonBase64.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buttonBase64.Size = new System.Drawing.Size(165, 32);
            this.buttonBase64.TabIndex = 1;
            this.buttonBase64.Text = "Base64";
            this.buttonBase64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBase64.UseVisualStyleBackColor = true;
            this.buttonBase64.Click += new System.EventHandler(this.buttonBase64_Click);
            // 
            // buttonMisc
            // 
            this.buttonMisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMisc.FlatAppearance.BorderSize = 0;
            this.buttonMisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMisc.Location = new System.Drawing.Point(0, 273);
            this.buttonMisc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMisc.Name = "buttonMisc";
            this.buttonMisc.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonMisc.Size = new System.Drawing.Size(165, 37);
            this.buttonMisc.TabIndex = 4;
            this.buttonMisc.Text = "Misc";
            this.buttonMisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMisc.UseVisualStyleBackColor = true;
            this.buttonMisc.Click += new System.EventHandler(this.buttonMisc_Click);
            // 
            // panelNetwork
            // 
            this.panelNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panelNetwork.Controls.Add(this.buttonTraceRoute);
            this.panelNetwork.Controls.Add(this.buttonPing);
            this.panelNetwork.Controls.Add(this.buttonIPGeoLocation);
            this.panelNetwork.Controls.Add(this.buttonIPHeader);
            this.panelNetwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNetwork.Location = new System.Drawing.Point(0, 143);
            this.panelNetwork.Margin = new System.Windows.Forms.Padding(2);
            this.panelNetwork.Name = "panelNetwork";
            this.panelNetwork.Size = new System.Drawing.Size(165, 130);
            this.panelNetwork.TabIndex = 3;
            // 
            // buttonTraceRoute
            // 
            this.buttonTraceRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTraceRoute.FlatAppearance.BorderSize = 0;
            this.buttonTraceRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTraceRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraceRoute.Location = new System.Drawing.Point(0, 96);
            this.buttonTraceRoute.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTraceRoute.Name = "buttonTraceRoute";
            this.buttonTraceRoute.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buttonTraceRoute.Size = new System.Drawing.Size(165, 32);
            this.buttonTraceRoute.TabIndex = 3;
            this.buttonTraceRoute.Text = "Trace Route";
            this.buttonTraceRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTraceRoute.UseVisualStyleBackColor = true;
            this.buttonTraceRoute.Click += new System.EventHandler(this.buttonTraceRoute_Click);
            // 
            // buttonPing
            // 
            this.buttonPing.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPing.FlatAppearance.BorderSize = 0;
            this.buttonPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPing.Location = new System.Drawing.Point(0, 64);
            this.buttonPing.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buttonPing.Size = new System.Drawing.Size(165, 32);
            this.buttonPing.TabIndex = 2;
            this.buttonPing.Text = "Ping";
            this.buttonPing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // buttonIPGeoLocation
            // 
            this.buttonIPGeoLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIPGeoLocation.FlatAppearance.BorderSize = 0;
            this.buttonIPGeoLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPGeoLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPGeoLocation.Location = new System.Drawing.Point(0, 32);
            this.buttonIPGeoLocation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIPGeoLocation.Name = "buttonIPGeoLocation";
            this.buttonIPGeoLocation.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buttonIPGeoLocation.Size = new System.Drawing.Size(165, 32);
            this.buttonIPGeoLocation.TabIndex = 1;
            this.buttonIPGeoLocation.Text = "IP Geo Location";
            this.buttonIPGeoLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIPGeoLocation.UseVisualStyleBackColor = true;
            this.buttonIPGeoLocation.Click += new System.EventHandler(this.buttonIPGeoLocation_Click);
            // 
            // buttonIPHeader
            // 
            this.buttonIPHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIPHeader.FlatAppearance.BorderSize = 0;
            this.buttonIPHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPHeader.Location = new System.Drawing.Point(0, 0);
            this.buttonIPHeader.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIPHeader.Name = "buttonIPHeader";
            this.buttonIPHeader.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buttonIPHeader.Size = new System.Drawing.Size(165, 32);
            this.buttonIPHeader.TabIndex = 0;
            this.buttonIPHeader.Text = "IP Header";
            this.buttonIPHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIPHeader.UseVisualStyleBackColor = true;
            this.buttonIPHeader.Click += new System.EventHandler(this.buttonIPHeader_Click);
            // 
            // buttonNetwork
            // 
            this.buttonNetwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNetwork.FlatAppearance.BorderSize = 0;
            this.buttonNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNetwork.Location = new System.Drawing.Point(0, 106);
            this.buttonNetwork.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNetwork.Name = "buttonNetwork";
            this.buttonNetwork.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonNetwork.Size = new System.Drawing.Size(165, 37);
            this.buttonNetwork.TabIndex = 2;
            this.buttonNetwork.Text = "Network";
            this.buttonNetwork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNetwork.UseVisualStyleBackColor = true;
            this.buttonNetwork.Click += new System.EventHandler(this.buttonNetwork_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 106);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.InitialImage = null;
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(165, 106);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(165, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(723, 73);
            this.panelTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(165, 73);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(723, 614);
            this.panelDesktop.TabIndex = 2;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(888, 687);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(904, 708);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetTools";
            this.panelMenu.ResumeLayout(false);
            this.panelMisc.ResumeLayout(false);
            this.panelNetwork.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNetwork;
        private System.Windows.Forms.Panel panelNetwork;
        private System.Windows.Forms.Button buttonTraceRoute;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.Button buttonIPGeoLocation;
        private System.Windows.Forms.Button buttonIPHeader;
        private System.Windows.Forms.Panel panelMisc;
        private System.Windows.Forms.Button buttonSIDConverter;
        private System.Windows.Forms.Button buttonBinaryConverter;
        private System.Windows.Forms.Button buttonBase64;
        private System.Windows.Forms.Button buttonMisc;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}

