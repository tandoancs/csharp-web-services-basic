using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace HolidaysApp
{
    public partial class HolidaysForm : Form
    {
        HolidaysBUS HoBUS = new HolidaysBUS();
        HolidaysDTO HoDTO = new HolidaysDTO();
        public HolidaysForm()
        {
            InitializeComponent();
        }

        private void HolidaysForm_Load(object sender, EventArgs e)
        {
            DgvHolidays.DataSource = HoBUS.ReadAll();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            HoDTO.Holiday_date = TxtHolidayDate.Text;

            var result = HoBUS.Create(HoDTO);



        }
    }
}
