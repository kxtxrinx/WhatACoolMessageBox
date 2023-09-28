namespace WhatACoolMessageBoxes
{
    partial class mainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.chBYes = new System.Windows.Forms.CheckBox();
            this.chBNo = new System.Windows.Forms.CheckBox();
            this.chBCancel = new System.Windows.Forms.CheckBox();
            this.grBButtons = new System.Windows.Forms.GroupBox();
            this.txBTitle = new System.Windows.Forms.TextBox();
            this.txBMessage = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pBNotepad = new System.Windows.Forms.PictureBox();
            this.lblSelectedBtns = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBInfo = new System.Windows.Forms.RadioButton();
            this.rdBError = new System.Windows.Forms.RadioButton();
            this.rdBWarning = new System.Windows.Forms.RadioButton();
            this.picturePaint = new System.Windows.Forms.PictureBox();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblSelectedOption = new System.Windows.Forms.Label();
            this.grBButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBNotepad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(281, 218);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(234, 289);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(127, 28);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message:";
            // 
            // chBYes
            // 
            this.chBYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chBYes.AutoSize = true;
            this.chBYes.Checked = true;
            this.chBYes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBYes.Enabled = false;
            this.chBYes.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBYes.Location = new System.Drawing.Point(27, 37);
            this.chBYes.Name = "chBYes";
            this.chBYes.Size = new System.Drawing.Size(117, 27);
            this.chBYes.TabIndex = 5;
            this.chBYes.Text = "Yes/OK";
            this.chBYes.UseVisualStyleBackColor = true;
            this.chBYes.CheckedChanged += new System.EventHandler(this.chBYes_CheckedChanged);
            this.chBYes.Paint += new System.Windows.Forms.PaintEventHandler(this.chBYes_Paint);
            // 
            // chBNo
            // 
            this.chBNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chBNo.AutoSize = true;
            this.chBNo.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBNo.Location = new System.Drawing.Point(27, 87);
            this.chBNo.Name = "chBNo";
            this.chBNo.Size = new System.Drawing.Size(61, 27);
            this.chBNo.TabIndex = 6;
            this.chBNo.Text = "No";
            this.chBNo.UseVisualStyleBackColor = true;
            this.chBNo.CheckedChanged += new System.EventHandler(this.chBNo_CheckedChanged);
            // 
            // chBCancel
            // 
            this.chBCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chBCancel.AutoSize = true;
            this.chBCancel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBCancel.Location = new System.Drawing.Point(27, 137);
            this.chBCancel.Name = "chBCancel";
            this.chBCancel.Size = new System.Drawing.Size(105, 27);
            this.chBCancel.TabIndex = 7;
            this.chBCancel.Text = "Cancel";
            this.chBCancel.UseVisualStyleBackColor = true;
            this.chBCancel.CheckedChanged += new System.EventHandler(this.chBCancel_CheckedChanged);
            // 
            // grBButtons
            // 
            this.grBButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grBButtons.BackColor = System.Drawing.Color.Transparent;
            this.grBButtons.Controls.Add(this.chBYes);
            this.grBButtons.Controls.Add(this.chBCancel);
            this.grBButtons.Controls.Add(this.chBNo);
            this.grBButtons.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBButtons.ForeColor = System.Drawing.Color.White;
            this.grBButtons.Location = new System.Drawing.Point(385, 393);
            this.grBButtons.Name = "grBButtons";
            this.grBButtons.Size = new System.Drawing.Size(277, 205);
            this.grBButtons.TabIndex = 8;
            this.grBButtons.TabStop = false;
            this.grBButtons.Text = "Buttons";
            this.grBButtons.Enter += new System.EventHandler(this.grBButtons_Enter);
            // 
            // txBTitle
            // 
            this.txBTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txBTitle.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBTitle.ForeColor = System.Drawing.Color.Black;
            this.txBTitle.Location = new System.Drawing.Point(373, 218);
            this.txBTitle.Name = "txBTitle";
            this.txBTitle.Size = new System.Drawing.Size(359, 40);
            this.txBTitle.TabIndex = 13;
            // 
            // txBMessage
            // 
            this.txBMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txBMessage.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBMessage.ForeColor = System.Drawing.Color.Black;
            this.txBMessage.Location = new System.Drawing.Point(373, 289);
            this.txBMessage.Name = "txBMessage";
            this.txBMessage.Size = new System.Drawing.Size(590, 40);
            this.txBMessage.TabIndex = 14;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGenerate.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerate.Location = new System.Drawing.Point(421, 614);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(201, 56);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "Craft!💫";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTitle1
            // 
            this.lblTitle1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(347, 11);
            this.lblTitle1.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(522, 75);
            this.lblTitle1.TabIndex = 17;
            this.lblTitle1.Text = "WHAT A COOL";
            // 
            // lblTitle2
            // 
            this.lblTitle2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(268, 70);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(619, 105);
            this.lblTitle2.TabIndex = 19;
            this.lblTitle2.Text = "MESSAGEBOX!";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(310, 165);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(507, 26);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Craft your own MessageBoxes in a few seconds";
            // 
            // pBNotepad
            // 
            this.pBNotepad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBNotepad.BackgroundImage = global::WhatACoolMessageBoxes.Properties.Resources.vivaldi_5EdVjVIWE9;
            this.pBNotepad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBNotepad.Location = new System.Drawing.Point(12, 458);
            this.pBNotepad.Name = "pBNotepad";
            this.pBNotepad.Size = new System.Drawing.Size(302, 233);
            this.pBNotepad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBNotepad.TabIndex = 24;
            this.pBNotepad.TabStop = false;
            this.pBNotepad.Click += new System.EventHandler(this.pBNotepad_Click);
            // 
            // lblSelectedBtns
            // 
            this.lblSelectedBtns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectedBtns.AutoSize = true;
            this.lblSelectedBtns.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedBtns.Location = new System.Drawing.Point(35, 557);
            this.lblSelectedBtns.Name = "lblSelectedBtns";
            this.lblSelectedBtns.Size = new System.Drawing.Size(165, 22);
            this.lblSelectedBtns.TabIndex = 25;
            this.lblSelectedBtns.Text = "➼ Yes/OK Button";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdBInfo);
            this.groupBox1.Controls.Add(this.rdBError);
            this.groupBox1.Controls.Add(this.rdBWarning);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(782, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 205);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icons";
            // 
            // rdBInfo
            // 
            this.rdBInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdBInfo.AutoSize = true;
            this.rdBInfo.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBInfo.Location = new System.Drawing.Point(26, 36);
            this.rdBInfo.Name = "rdBInfo";
            this.rdBInfo.Size = new System.Drawing.Size(152, 27);
            this.rdBInfo.TabIndex = 9;
            this.rdBInfo.TabStop = true;
            this.rdBInfo.Text = "Information";
            this.rdBInfo.UseVisualStyleBackColor = true;
            // 
            // rdBError
            // 
            this.rdBError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdBError.AutoSize = true;
            this.rdBError.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBError.Location = new System.Drawing.Point(26, 137);
            this.rdBError.Name = "rdBError";
            this.rdBError.Size = new System.Drawing.Size(85, 27);
            this.rdBError.TabIndex = 11;
            this.rdBError.TabStop = true;
            this.rdBError.Text = "Error";
            this.rdBError.UseVisualStyleBackColor = true;
            // 
            // rdBWarning
            // 
            this.rdBWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdBWarning.AutoSize = true;
            this.rdBWarning.BackColor = System.Drawing.Color.Transparent;
            this.rdBWarning.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBWarning.Location = new System.Drawing.Point(26, 87);
            this.rdBWarning.Name = "rdBWarning";
            this.rdBWarning.Size = new System.Drawing.Size(114, 27);
            this.rdBWarning.TabIndex = 10;
            this.rdBWarning.TabStop = true;
            this.rdBWarning.Text = "Warning";
            this.rdBWarning.UseVisualStyleBackColor = false;
            // 
            // picturePaint
            // 
            this.picturePaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picturePaint.BackColor = System.Drawing.Color.Transparent;
            this.picturePaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePaint.Image = global::WhatACoolMessageBoxes.Properties.Resources.bg2_preview_rev_1;
            this.picturePaint.Location = new System.Drawing.Point(696, 346);
            this.picturePaint.Name = "picturePaint";
            this.picturePaint.Size = new System.Drawing.Size(417, 354);
            this.picturePaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePaint.TabIndex = 23;
            this.picturePaint.TabStop = false;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.lblCurrentDate.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.lblCurrentDate.Location = new System.Drawing.Point(1029, 727);
            this.lblCurrentDate.Margin = new System.Windows.Forms.Padding(0, 0, 40, 40);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.lblCurrentDate.Size = new System.Drawing.Size(40, 19);
            this.lblCurrentDate.TabIndex = 28;
            // 
            // lblSelectedOption
            // 
            this.lblSelectedOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectedOption.AutoSize = true;
            this.lblSelectedOption.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOption.Location = new System.Drawing.Point(35, 637);
            this.lblSelectedOption.Name = "lblSelectedOption";
            this.lblSelectedOption.Size = new System.Drawing.Size(0, 22);
            this.lblSelectedOption.TabIndex = 29;
            // 
            // mainWindow
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::WhatACoolMessageBoxes.Properties.Resources.bgWDate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 758);
            this.Controls.Add(this.lblSelectedOption);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSelectedBtns);
            this.Controls.Add(this.pBNotepad);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txBMessage);
            this.Controls.Add(this.txBTitle);
            this.Controls.Add(this.grBButtons);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picturePaint);
            this.MinimumSize = new System.Drawing.Size(1073, 674);
            this.Name = "mainWindow";
            this.Text = "MessageBoxes Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.mainWindow_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainWindow_MouseClick);
            this.grBButtons.ResumeLayout(false);
            this.grBButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBNotepad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox chBYes;
        private System.Windows.Forms.CheckBox chBNo;
        private System.Windows.Forms.CheckBox chBCancel;
        private System.Windows.Forms.GroupBox grBButtons;
        private System.Windows.Forms.TextBox txBTitle;
        private System.Windows.Forms.TextBox txBMessage;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pBNotepad;
        private System.Windows.Forms.Label lblSelectedBtns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBInfo;
        private System.Windows.Forms.RadioButton rdBError;
        private System.Windows.Forms.RadioButton rdBWarning;
        private System.Windows.Forms.PictureBox picturePaint;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblSelectedOption;
    }
}

