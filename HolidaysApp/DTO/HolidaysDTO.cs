using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HolidaysDTO
    {
        private int Id;
        private string holiday_date;
        private string holiday_name_group;
        private string holiday_name_en;
        private string holiday_name_vi;
        private string remark;
        private string updated_by;
        private DateTime updated_date;

        public int ID { get => Id; set => Id = value; }
        public string Holiday_date { get => holiday_date; set => holiday_date = value; }
        public string Holiday_name_group { get => holiday_name_group; set => holiday_name_group = value; }
        public string Holiday_name_en { get => holiday_name_en; set => holiday_name_en = value; }
        public string Holiday_name_vi { get => holiday_name_vi; set => holiday_name_vi = value; }
        public string Remark { get => remark; set => remark = value; }
        public string Updated_by { get => updated_by; set => updated_by = value; }
        public DateTime Updated_date { get => updated_date; set => updated_date = value; }

        public HolidaysDTO()
        {

        }

        public HolidaysDTO(int Id, string holiday_date, string holiday_name_group, string holiday_name_en, string holiday_name_vi, string remark, string updated_by, DateTime updated_date)
        {
            this.ID = Id;
            this.Holiday_date = holiday_date;
            this.Holiday_name_group = holiday_name_group;
            this.Holiday_name_en = holiday_name_en;
            this.Holiday_name_vi = holiday_name_vi;
            this.Remark = remark;

            this.Updated_by = updated_by;
            this.Updated_date = updated_date;
        }

    }
}
