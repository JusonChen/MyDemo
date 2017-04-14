using Dao;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class winformManager:BaseManager
    {
        private winformDao wfDao = null;

        public override void OnInit()
        {
            wfDao = DaoFactory<winformDao>.GetDao();
        }

        public void Insert(User user)
        {
            wfDao.Insert(user);
        }

    }
}
