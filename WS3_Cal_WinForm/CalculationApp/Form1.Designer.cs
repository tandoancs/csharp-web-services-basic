
namespace CalculationApp
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
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDiv = new FontAwesome.Sharp.IconButton();
            this.BtnMul = new FontAwesome.Sharp.IconButton();
            this.BtnSub = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNumber1 = new System.Windows.Forms.Label();
            this.TxtNumber1 = new Magic_Key.MagicControl.MagicTextBox();
            this.TxtNumber2 = new Magic_Key.MagicControl.MagicTextBox();
            this.PnlResult = new System.Windows.Forms.Panel();
            this.BtnResult = new FontAwesome.Sharp.IconButton();
            this.PnlTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.PnlTitle.Controls.Add(this.label1);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTitle.ForeColor = System.Drawing.Color.White;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(619, 61);
            this.PnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculation App";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.BtnDiv);
            this.panel2.Controls.Add(this.BtnMul);
            this.panel2.Controls.Add(this.BtnSub);
            this.panel2.Controls.Add(this.BtnAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LblNumber1);
            this.panel2.Controls.Add(this.TxtNumber1);
            this.panel2.Controls.Add(this.TxtNumber2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.MediumBlue;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 194);
            this.panel2.TabIndex = 0;
            // 
            // BtnDiv
            // 
            this.BtnDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiv.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.IconChar = FontAwesome.Sharp.IconChar.D;
            this.BtnDiv.IconColor = System.Drawing.Color.Red;
            this.BtnDiv.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.BtnDiv.IconSize = 22;
            this.BtnDiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDiv.Location = new System.Drawing.Point(312, 134);
            this.BtnDiv.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnDiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDiv.Size = new System.Drawing.Size(85, 28);
            this.BtnDiv.TabIndex = 2;
            this.BtnDiv.Text = "iv (/)";
            this.BtnDiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMul.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMul.IconChar = FontAwesome.Sharp.IconChar.M;
            this.BtnMul.IconColor = System.Drawing.Color.Red;
            this.BtnMul.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.BtnMul.IconSize = 22;
            this.BtnMul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMul.Location = new System.Drawing.Point(212, 134);
            this.BtnMul.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtnMul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMul.Size = new System.Drawing.Size(85, 28);
            this.BtnMul.TabIndex = 2;
            this.BtnMul.Text = "ul (*)";
            this.BtnMul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSub.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.IconChar = FontAwesome.Sharp.IconChar.S;
            this.BtnSub.IconColor = System.Drawing.Color.Red;
            this.BtnSub.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.BtnSub.IconSize = 22;
            this.BtnSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSub.Location = new System.Drawing.Point(112, 134);
            this.BtnSub.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.BtnSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSub.Size = new System.Drawing.Size(85, 28);
            this.BtnSub.TabIndex = 2;
            this.BtnSub.Text = "ub (-)";
            this.BtnSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.A;
            this.BtnAdd.IconColor = System.Drawing.Color.Red;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.BtnAdd.IconSize = 22;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(14, 134);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAdd.Size = new System.Drawing.Size(85, 28);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "ad (+)";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number (2nd)";
            // 
            // LblNumber1
            // 
            this.LblNumber1.AutoSize = true;
            this.LblNumber1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumber1.Location = new System.Drawing.Point(12, 30);
            this.LblNumber1.Name = "LblNumber1";
            this.LblNumber1.Size = new System.Drawing.Size(81, 17);
            this.LblNumber1.TabIndex = 0;
            this.LblNumber1.Text = "Number (1st)";
            // 
            // TxtNumber1
            // 
            this.TxtNumber1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNumber1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNumber1.BorderSize = 2;
            this.TxtNumber1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNumber1.ForeColor = System.Drawing.Color.DarkRed;
            this.TxtNumber1.Location = new System.Drawing.Point(119, 22);
            this.TxtNumber1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumber1.Multiline = false;
            this.TxtNumber1.Name = "TxtNumber1";
            this.TxtNumber1.Padding = new System.Windows.Forms.Padding(7);
            this.TxtNumber1.PasswordChar = false;
            this.TxtNumber1.Size = new System.Drawing.Size(278, 32);
            this.TxtNumber1.TabIndex = 0;
            this.TxtNumber1.Texts = "";
            this.TxtNumber1.UnderlinedStyle = false;
            // 
            // TxtNumber2
            // 
            this.TxtNumber2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNumber2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNumber2.BorderSize = 2;
            this.TxtNumber2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNumber2.ForeColor = System.Drawing.Color.DarkRed;
            this.TxtNumber2.Location = new System.Drawing.Point(119, 61);
            this.TxtNumber2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumber2.Multiline = false;
            this.TxtNumber2.Name = "TxtNumber2";
            this.TxtNumber2.Padding = new System.Windows.Forms.Padding(7);
            this.TxtNumber2.PasswordChar = false;
            this.TxtNumber2.Size = new System.Drawing.Size(278, 32);
            this.TxtNumber2.TabIndex = 0;
            this.TxtNumber2.Texts = "";
            this.TxtNumber2.UnderlinedStyle = false;
            // 
            // PnlResult
            // 
            this.PnlResult.BackColor = System.Drawing.Color.LightCyan;
            this.PnlResult.Controls.Add(this.BtnResult);
            this.PnlResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlResult.Location = new System.Drawing.Point(426, 61);
            this.PnlResult.Name = "PnlResult";
            this.PnlResult.Size = new System.Drawing.Size(193, 194);
            this.PnlResult.TabIndex = 1;
            // 
            // BtnResult
            // 
            this.BtnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResult.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResult.ForeColor = System.Drawing.Color.Red;
            this.BtnResult.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnResult.IconColor = System.Drawing.Color.Red;
            this.BtnResult.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.BtnResult.IconSize = 22;
            this.BtnResult.Location = new System.Drawing.Point(37, 42);
            this.BtnResult.Margin = new System.Windows.Forms.Padding(0);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnResult.Size = new System.Drawing.Size(118, 85);
            this.BtnResult.TabIndex = 2;
            this.BtnResult.Text = "res";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(619, 255);
            this.Controls.Add(this.PnlResult);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNumber1;
        private Magic_Key.MagicControl.MagicTextBox TxtNumber2;
        private Magic_Key.MagicControl.MagicTextBox TxtNumber1;
        private FontAwesome.Sharp.IconButton BtnDiv;
        private FontAwesome.Sharp.IconButton BtnMul;
        private FontAwesome.Sharp.IconButton BtnSub;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private System.Windows.Forms.Panel PnlResult;
        private FontAwesome.Sharp.IconButton BtnResult;
    }
}

