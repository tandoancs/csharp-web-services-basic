
namespace DBSampleForm
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
            this.DgvMasterData = new System.Windows.Forms.DataGridView();
            this.TxtItem = new System.Windows.Forms.TextBox();
            this.BtnReadItem = new System.Windows.Forms.Button();
            this.LblItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMasterData)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMasterData
            // 
            this.DgvMasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMasterData.Location = new System.Drawing.Point(12, 137);
            this.DgvMasterData.Name = "DgvMasterData";
            this.DgvMasterData.RowHeadersWidth = 62;
            this.DgvMasterData.RowTemplate.Height = 28;
            this.DgvMasterData.Size = new System.Drawing.Size(776, 301);
            this.DgvMasterData.TabIndex = 0;
            // 
            // TxtItem
            // 
            this.TxtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItem.Location = new System.Drawing.Point(230, 45);
            this.TxtItem.Name = "TxtItem";
            this.TxtItem.Size = new System.Drawing.Size(187, 39);
            this.TxtItem.TabIndex = 2;
            // 
            // BtnReadItem
            // 
            this.BtnReadItem.Location = new System.Drawing.Point(478, 37);
            this.BtnReadItem.Name = "BtnReadItem";
            this.BtnReadItem.Size = new System.Drawing.Size(100, 47);
            this.BtnReadItem.TabIndex = 3;
            this.BtnReadItem.Text = "Read Item";
            this.BtnReadItem.UseVisualStyleBackColor = true;
            this.BtnReadItem.Click += new System.EventHandler(this.BtnReadItem_Click);
            // 
            // LblItem
            // 
            this.LblItem.AutoSize = true;
            this.LblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItem.Location = new System.Drawing.Point(104, 48);
            this.LblItem.Name = "LblItem";
            this.LblItem.Size = new System.Drawing.Size(69, 32);
            this.LblItem.TabIndex = 4;
            this.LblItem.Text = "Item";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblItem);
            this.Controls.Add(this.BtnReadItem);
            this.Controls.Add(this.TxtItem);
            this.Controls.Add(this.DgvMasterData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMasterData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMasterData;
        private System.Windows.Forms.TextBox TxtItem;
        private System.Windows.Forms.Button BtnReadItem;
        private System.Windows.Forms.Label LblItem;
    }
}

