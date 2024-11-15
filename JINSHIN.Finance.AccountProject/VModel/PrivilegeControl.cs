using JINSHIN.Business.DataBase;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.VModel
{
    public  class PrivilegeControl : JBase
    {
        public List<JINSHINFINANCE018> GetUserData(int power,string usrno)
        {
            switch (power)
            {
                //case 0:return SytemGetUser();
                //case 1:return ManagerGetDeptUser(usrno);
                case 2:return GetUser(usrno);
            }
            return null;
        }

        /// <summary>
        /// 一般使用者
        /// </summary>
        /// <returns></returns>
        public List<JINSHINFINANCE018> GetUser(string usrno)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    return entities.JINSHINFINANCE018.Where(v => v.UsrNo == usrno).ToList();
                }
            }
        }

        /// <summary>
        /// 系統管理員
        /// </summary>
        /// <returns></returns>
        public List<JINSHINFINANCE018> SytemGetUser()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    return entities.JINSHINFINANCE018.Where(v=>v.Enable == true).ToList();
                }
            }
        }
        /// <summary>
        /// 主管
        /// </summary>
        /// <param name="usrno"></param>
        /// <returns></returns>
        public List<JINSHINFINANCE018> ManagerGetDeptUser(string usrno)
        {
            List<JINSHINFINANCE018> rs = new List<JINSHINFINANCE018>();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var jin18 = entity.JINSHINFINANCE018.Where(v => v.UsrNo == DataClass.usrno).FirstOrDefault();
                     //區分職務再處理
                    //var jin06 = entity.JINSHINFINANCE006.Where(v => v.DeptNo == jin18.deptno).FirstOrDefault();
                    //var jin06lst = entity.JINSHINFINANCE006.Where(v => v.DeptLink > jin06.DeptLink).ToList();
                    //jin06lst.Add(jin06);
                    //上一層部門
                    //foreach (var item in jin06lst)
                    //{
                    //    var data = entity.JINSHINFINANCE018.Where(v => v.deptno == item.DeptNo &&v.Enable == true).ToList();
                    //    rs.AddRange(data);
                    //}                    
                }
            }
            return rs;        
        }
    }
}
