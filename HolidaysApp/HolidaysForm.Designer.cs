
namespace HolidaysApp
{
    partial class HolidaysForm
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
            this.DgvHolidays = new System.Windows.Forms.DataGridView();
            this.TxtHolidayDate = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHolidays)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvHolidays
            // 
            this.DgvHolidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHolidays.Location = new System.Drawing.Point(1, 182);
            this.DgvHolidays.Name = "DgvHolidays";
            this.DgvHolidays.RowHeadersWidth = 62;
            this.DgvHolidays.RowTemplate.Height = 28;
            this.DgvHolidays.Size = new System.Drawing.Size(1146, 352);
            this.DgvHolidays.TabIndex = 0;
            // 
            // TxtHolidayDate
            // 
            this.TxtHolidayDate.Location = new System.Drawing.Point(483, 79);
            this.TxtHolidayDate.Name = "TxtHolidayDate";
            this.TxtHolidayDate.Size = new System.Drawing.Size(315, 26);
            this.TxtHolidayDate.TabIndex = 1;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(855, 60);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 64);
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // HolidaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 536);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtHolidayDate);
            this.Controls.Add(this.DgvHolidays);
            this.Name = "HolidaysForm";
            this.Text = "HolidaysForm";
            this.Load += new System.EventHandler(this.HolidaysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHolidays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvHolidays;
        private System.Windows.Forms.TextBox TxtHolidayDate;
        private System.Windows.Forms.Button BtnCreate;
    }
}

