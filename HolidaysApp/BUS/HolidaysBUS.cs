using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class HolidaysBUS
    {
        Holidays ho = new Holidays();
        public DataTable ReadAll()
        {
            return ho.ReadAll();
        }

        public bool Create(HolidaysDTO HoDTO)
        {
            return ho.Create(HoDTO);
        }
    }
}
