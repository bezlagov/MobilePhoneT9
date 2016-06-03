using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneT9.Model
{
    class Dict
    {
        public int Id { get; set; }
        public string Russian { get; set; }
        public string English { get; set; }
        public Dict(int id, string russian, string english)
        {
            Id = id;
            Russian = russian;
            English = english;
        }
    }
}
