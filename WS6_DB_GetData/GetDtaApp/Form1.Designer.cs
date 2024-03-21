
namespace GetDtaApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUsersMa = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.BtnAllUsers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.LblUsersMa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 66);
            this.panel1.TabIndex = 0;
            // 
            // LblUsersMa
            // 
            this.LblUsersMa.AutoSize = true;
            this.LblUsersMa.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsersMa.ForeColor = System.Drawing.Color.Crimson;
            this.LblUsersMa.Location = new System.Drawing.Point(215, 21);
            this.LblUsersMa.Name = "LblUsersMa";
            this.LblUsersMa.Size = new System.Drawing.Size(202, 26);
            this.LblUsersMa.TabIndex = 3;
            this.LblUsersMa.Text = "Users Management";
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.Blue;
            this.BtnSearch.Location = new System.Drawing.Point(156, 89);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(129, 26);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.ForeColor = System.Drawing.Color.Red;
            this.TxtId.Location = new System.Drawing.Point(12, 89);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(120, 26);
            this.TxtId.TabIndex = 2;
            // 
            // DgvUsers
            // 
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvUsers.Location = new System.Drawing.Point(0, 143);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.Size = new System.Drawing.Size(558, 216);
            this.DgvUsers.TabIndex = 4;
            // 
            // BtnAllUsers
            // 
            this.BtnAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllUsers.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAllUsers.ForeColor = System.Drawing.Color.Blue;
            this.BtnAllUsers.Location = new System.Drawing.Point(401, 89);
            this.BtnAllUsers.Name = "BtnAllUsers";
            this.BtnAllUsers.Size = new System.Drawing.Size(129, 26);
            this.BtnAllUsers.TabIndex = 1;
            this.BtnAllUsers.Text = "All Users";
            this.BtnAllUsers.UseVisualStyleBackColor = true;
            this.BtnAllUsers.Click += new System.EventHandler(this.BtnAllUsers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 359);
            this.Controls.Add(this.DgvUsers);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnAllUsers);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblUsersMa;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.Button BtnAllUsers;
    }
}

