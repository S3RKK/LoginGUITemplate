namespace Template1
{
    partial class Backround
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backround));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PasswordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RememberLoginCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.LoginTextLabel = new System.Windows.Forms.Label();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.RememberLoginLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Gray;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(96, 139);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(210, 31);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.TabStop = false;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.White;
            this.UsernameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.UsernameTextBox.HintText = "";
            this.UsernameTextBox.isPassword = false;
            this.UsernameTextBox.LineFocusedColor = System.Drawing.Color.LightGray;
            this.UsernameTextBox.LineIdleColor = System.Drawing.Color.LightGray;
            this.UsernameTextBox.LineMouseHoverColor = System.Drawing.Color.LightGray;
            this.UsernameTextBox.LineThickness = 1;
            this.UsernameTextBox.Location = new System.Drawing.Point(96, 50);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(211, 24);
            this.UsernameTextBox.TabIndex = 5;
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.PasswordTextBox.HintText = "";
            this.PasswordTextBox.isPassword = true;
            this.PasswordTextBox.LineFocusedColor = System.Drawing.Color.LightGray;
            this.PasswordTextBox.LineIdleColor = System.Drawing.Color.LightGray;
            this.PasswordTextBox.LineMouseHoverColor = System.Drawing.Color.LightGray;
            this.PasswordTextBox.LineThickness = 1;
            this.PasswordTextBox.Location = new System.Drawing.Point(97, 82);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(210, 24);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RememberLoginCheckBox
            // 
            this.RememberLoginCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.RememberLoginCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.RememberLoginCheckBox.Checked = false;
            this.RememberLoginCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.RememberLoginCheckBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RememberLoginCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(48)))));
            this.RememberLoginCheckBox.Location = new System.Drawing.Point(97, 113);
            this.RememberLoginCheckBox.Name = "RememberLoginCheckBox";
            this.RememberLoginCheckBox.Size = new System.Drawing.Size(20, 20);
            this.RememberLoginCheckBox.TabIndex = 3;
            this.RememberLoginCheckBox.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // LoginTextLabel
            // 
            this.LoginTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTextLabel.ForeColor = System.Drawing.Color.White;
            this.LoginTextLabel.Location = new System.Drawing.Point(92, 9);
            this.LoginTextLabel.Name = "LoginTextLabel";
            this.LoginTextLabel.Size = new System.Drawing.Size(108, 28);
            this.LoginTextLabel.TabIndex = 4;
            this.LoginTextLabel.Text = "Login";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(369, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(17, 18);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // RememberLoginLabel
            // 
            this.RememberLoginLabel.AutoSize = true;
            this.RememberLoginLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberLoginLabel.ForeColor = System.Drawing.Color.White;
            this.RememberLoginLabel.Location = new System.Drawing.Point(123, 113);
            this.RememberLoginLabel.Name = "RememberLoginLabel";
            this.RememberLoginLabel.Size = new System.Drawing.Size(104, 17);
            this.RememberLoginLabel.TabIndex = 6;
            this.RememberLoginLabel.Text = "Remember Login";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.LoginTextLabel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Backround
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(396, 258);
            this.Controls.Add(this.RememberLoginLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LoginTextLabel);
            this.Controls.Add(this.RememberLoginCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.LoginButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Backround";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private System.Windows.Forms.Label LoginTextLabel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        protected internal System.Windows.Forms.Button LoginButton;
        protected internal Bunifu.Framework.UI.BunifuCheckbox RememberLoginCheckBox;
        protected internal Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTextBox;
        protected internal Bunifu.Framework.UI.BunifuMaterialTextbox UsernameTextBox;
        protected internal System.Windows.Forms.Label RememberLoginLabel;
    }
}

