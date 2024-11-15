using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Sercurity;
using JINSHIN.FinanceAccount.Libary.VModels.Config;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.Interface.Data.Models.Register;
using JINSHIN.RegProcess.Liary.Content.Register.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinanceAccountProgram.Models
{
    public class usermodel : JBase
    {
        public string username { get; set; }
        public string pass { get; set; }
        public string idname { get; set; }
        public string userphone { get; set; }
    }

    public class ChkVModel :JBase
    {
        public void RefreshServerIP(string srvname)
        {
            using (SysSettingCtl ctl = new SysSettingCtl())
            {
                string srvadr = ctl.LoadData(srvname);
                WindowSetting.SrvIP = srvadr;
                WindowSetting.OnServiceWeb = srvadr + WindowSetting.OnServicePort;
            }
        }
        /// <summary>
        /// 檢查使用者帳號
        /// 廠商       
        /// </summary>
        /// <param name="val"></param>
        /// <param name="entity"></param>
        /// <param name="user"></param>
        /// <param name="msgmodel"></param>
        /// <returns></returns>
        public bool CheckUserInfo(CTAInfoSysap val, AccountEntities entity, 
            JINSHINFINANCE018 user, RegUserModel msgmodel)
        {
          
            var supply = entity.JINSHINFINANCE012.Where(o => o.No == user.SupplyNo).FirstOrDefault();
            if (supply == null)
            {
                MessageBox.Show(msgmodel.RegInputError01, msgmodel.title, MessageBoxButtons.OKCancel);
                return true;
            }
            else
            {
                if (val.IdNo != supply.IdNo)
                {
                    MessageBox.Show(msgmodel.RegUserMsg007, msgmodel.title, MessageBoxButtons.OKCancel);
                    return true;
                }
                else if (val.Supply != supply.Supply)
                {
                    MessageBox.Show(msgmodel.RegUserMsg005, msgmodel.title, MessageBoxButtons.OKCancel);
                    return true;
                }
                if (CheckSupplyKey(val, supply, true, msgmodel))
                    return true;
            }

            return false;
        }


        /// <summary>
        /// 廠商資料若審核完成
        /// 若審核未完成
        /// </summary>
        /// <param name="val"></param>
        /// <param name="supply"></param>
        /// <param name="UserExists"></param>
        /// <returns></returns>
        public bool CheckSupplyKey(CTAInfoSysap val, JINSHINFINANCE012 supply, bool UserExists, RegUserModel msgmodel)
        {
            if (val.SupplyRight)
            {
                if (!(val.Supply == val.ServerSupply && val.IdNo == supply.IdNo && val.ServerSubKey.ToUpper() == val.SupKey.ToUpper()))
                {
                    string msg = "";
                    msg = UserExists ? msgmodel.RegUserMsg003 : msgmodel.RegUserMsg006;
                    MessageBox.Show(msg, msgmodel.title, MessageBoxButtons.OKCancel);
                    return true;
                }
            }         
            return false;
        }

        /// <summary>
        ///檢查id 及使用者名稱不為空值及空白 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="idname"></param>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public bool ChkUser(string username,string idname,string msg,string title)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(idname))
            {
                MessageBox.Show(msg, title, MessageBoxButtons.OKCancel);
                return false;
            }
            return true;
        }
        /// <summary>
        /// 檢查鍵值不為空值及空白 
        /// </summary>
        /// <param name="keuval"></param>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public bool ChkKey(string keuval,  string msg, string title)
        {
            if (string.IsNullOrEmpty(keuval) )
            {
                MessageBox.Show(msg, title, MessageBoxButtons.OKCancel);
                return false;
            }
            return true;
        }
        /// <summary>
        /// 檢查鍵值、統一編號、廠商名稱不為空值及空白 
        /// </summary>
        /// <param name="key">鍵值</param>
        /// <param name="IdNo">統一編號</param>
        /// <param name="Supply">廠商名稱</param>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public bool ChkCompanyDataEmpty(string key,string IdNo,string Supply, string msg, string title)
        {
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(IdNo) || string.IsNullOrEmpty(Supply))
            {
                MessageBox.Show(msg, title, MessageBoxButtons.OKCancel);
                return true;
            }
            return false;
        }
        /// <summary>
        /// 比對使用者資訊，包括名稱、使用者帳號、密碼及電話
        /// </summary>
        /// <param name="usrmodel"></param>
        /// <param name="IsLock"></param>
        /// <param name="data"></param>
        /// <param name="CreateUser"></param>
        /// <param name="val"></param>
        /// <param name="msgmodel"></param>
        /// <returns></returns>
        public bool ChkUserInfoWhenExists(usermodel usrmodel,bool IsLock,CTAInfoSysap data,
            bool CreateUser, JINSHINFINANCE018 val, RegUserModel msgmodel)
        {
            if (CreateUser)
            {
                if (val.IDName != data.IdName)
                {
                    MessageBox.Show(msgmodel.RegUserMsg001, msgmodel.title, MessageBoxButtons.OKCancel);
                    return true;
                }
            }
            if (data != null)
            {
                data.usrno = val.UsrNo;
                data.UserOUID = val.OUID;
            }
            if (IsLock)
            {
                MessageBox.Show(msgmodel.LoginLock, msgmodel.title, MessageBoxButtons.OKCancel);
                return true;
            }
            if (!(val.UserName == usrmodel.username && val.Pass == usrmodel.pass
                && val.IDName == usrmodel.idname && val.UserPhone == usrmodel.userphone))
            {
                MessageBox.Show(msgmodel.UserNameTheSame, msgmodel.title, MessageBoxButtons.OKCancel);
                return true;
            }
            return false;
        }
    }
}
