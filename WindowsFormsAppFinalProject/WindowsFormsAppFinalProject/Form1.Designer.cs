namespace WindowsFormsAppFinalProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBoxClient = new System.Windows.Forms.RichTextBox();
            this.richTextBoxServer = new System.Windows.Forms.RichTextBox();
            this.labelYour = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.labelPeer = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelTittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(190, 100);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 26);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(295, 100);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(376, 26);
            this.textBoxStatus.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.ImageIndex = 2;
            this.buttonStart.ImageList = this.imageList1;
            this.buttonStart.Location = new System.Drawing.Point(809, 27);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(232, 41);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "incoming.png");
            this.imageList1.Images.SetKeyName(1, "search.jpg");
            this.imageList1.Images.SetKeyName(2, "start3.png");
            // 
            // richTextBoxClient
            // 
            this.richTextBoxClient.Location = new System.Drawing.Point(166, 251);
            this.richTextBoxClient.Name = "richTextBoxClient";
            this.richTextBoxClient.Size = new System.Drawing.Size(256, 191);
            this.richTextBoxClient.TabIndex = 4;
            this.richTextBoxClient.Text = "";
            // 
            // richTextBoxServer
            // 
            this.richTextBoxServer.Location = new System.Drawing.Point(498, 251);
            this.richTextBoxServer.Name = "richTextBoxServer";
            this.richTextBoxServer.Size = new System.Drawing.Size(256, 191);
            this.richTextBoxServer.TabIndex = 5;
            this.richTextBoxServer.Text = "";
            // 
            // labelYour
            // 
            this.labelYour.AutoSize = true;
            this.labelYour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYour.Location = new System.Drawing.Point(161, 209);
            this.labelYour.Name = "labelYour";
            this.labelYour.Size = new System.Drawing.Size(139, 25);
            this.labelYour.TabIndex = 6;
            this.labelYour.Text = "Your Message";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConnect.ImageIndex = 1;
            this.buttonConnect.ImageList = this.imageList1;
            this.buttonConnect.Location = new System.Drawing.Point(809, 85);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(232, 41);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.Text = "Send Request";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccept.ImageIndex = 0;
            this.buttonAccept.ImageList = this.imageList1;
            this.buttonAccept.Location = new System.Drawing.Point(809, 146);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(232, 41);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Accept Request";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // labelPeer
            // 
            this.labelPeer.AutoSize = true;
            this.labelPeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeer.Location = new System.Drawing.Point(493, 209);
            this.labelPeer.Name = "labelPeer";
            this.labelPeer.Size = new System.Drawing.Size(139, 25);
            this.labelPeer.TabIndex = 9;
            this.labelPeer.Text = "Peer Message";
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(239, 459);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(121, 41);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTittle.Location = new System.Drawing.Point(309, 27);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(303, 32);
            this.labelTittle.TabIndex = 0;
            this.labelTittle.Text = "Bluetooth Messenger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 531);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelPeer);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelYour);
            this.Controls.Add(this.richTextBoxServer);
            this.Controls.Add(this.richTextBoxClient);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bluetooth Messenger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox richTextBoxClient;
        private System.Windows.Forms.RichTextBox richTextBoxServer;
        private System.Windows.Forms.Label labelYour;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label labelPeer;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelTittle;
    }
}

