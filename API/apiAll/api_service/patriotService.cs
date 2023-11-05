using api_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_service
{
    public class patriotService
    {

        readonly DB _data;
        public patriotService(DB data)
        {
            _data = data;
        }
        public IEnumerable<Loction> Getdata()
        {
            return _data.data;
        }
        public bool add(Loction l)
        {
            foreach (var x in _data.data)
            {
                if (x.MisleState.Id == l.MisleState.Id)
                {
                    return false;
                }
            }
               _data.data.Add(l);
            return true;
        }
    }
}
