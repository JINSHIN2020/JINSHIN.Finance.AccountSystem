using FinanceAccountProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using JINSHIN.BUSINESS.LIBARY.Base;

namespace FinanceAccountProgram.VModel.PlayerRound
{
    public class MedialFile : JBase
    {
        public int sn { get; set; }
        public string path { get; set; }
        public string name { get; set; }
    }
    public class PlayVModel :JBase
    {
        public const string prefix = @"file:\\\";
        public const string mediapath = @"\audio";
        public WindowsMediaPlayer media { get; set; }
        public List<MedialFile> mediafiles { get; set; }
        public PlayVModel(string basePath)
        {
            media = new WindowsMediaPlayer();
            mediafiles = new List<MedialFile>();
            mediafiles.Add(new MedialFile() { sn=1, path = prefix + basePath + mediapath + @"\001.m4a" ,name = "開口詞" });
            mediafiles.Add(new MedialFile() { sn = 2, path = prefix + basePath+mediapath + @"\002.m4a", name = "登入成功" });
            mediafiles.Add(new MedialFile() { sn = 3, path = prefix + basePath+mediapath + @"\003.m4a", name = "帳簿轉換功能" });
            mediafiles.Add(new MedialFile() { sn = 4, path = prefix + basePath+mediapath + @"\005.m4a", name = "資料匯入勾稽比對" });
            mediafiles.Add(new MedialFile() { sn = 5, path = prefix + basePath+mediapath + @"\006.m4a", name = "智慧帳冊" });
            mediafiles.Add(new MedialFile() { sn = 6, path = prefix + basePath+mediapath + @"\007.m4a", name = "智慧帳冊月管理功能" });
            mediafiles.Add(new MedialFile() { sn = 7, path = prefix + basePath+mediapath + @"\008.m4a", name = "憑證類別管理" });
            mediafiles.Add(new MedialFile() { sn = 8, path = prefix + basePath+mediapath + @"\009.m4a", name = "帳目類別管理" });
            mediafiles.Add(new MedialFile() { sn = 9, path = prefix + basePath+ mediapath + @"\010.m4a", name = "會計金額結算" });
            mediafiles.Add(new MedialFile() { sn = 10, path = prefix + basePath+mediapath + @"\011.m4a", name = "匯入帳務管理" });
            mediafiles.Add(new MedialFile() { sn = 11, path = prefix + basePath + mediapath + @"\012.m4a", name = "帳目資料管理" });
            mediafiles.Add(new MedialFile() { sn = 12, path = prefix + basePath+mediapath + @"\013.m4a", name = "帳目智慧比對訊息提示" });
            mediafiles.Add(new MedialFile() { sn = 13, path = prefix + basePath+mediapath + @"\015.m4a", name = "帳務檢視" });
            mediafiles.Add(new MedialFile() { sn = 14, path = prefix + basePath+mediapath + @"\016.m4a", name = "資產及折舊產出" });
            mediafiles.Add(new MedialFile() { sn = 15, path = prefix + basePath+mediapath + @"\017.m4a", name = "會計科目勾稽功能" });
            mediafiles.Add(new MedialFile() { sn = 16, path = prefix + basePath+mediapath + @"\018.m4a", name = "資產折舊勾稽比對" });
            mediafiles.Add(new MedialFile() { sn = 17, path = prefix + basePath+mediapath + @"\019.m4a", name = "系統總帳管理" });
            mediafiles.Add(new MedialFile() { sn = 18, path = prefix + basePath+mediapath + @"\020.m4a", name = "損益表" });
            mediafiles.Add(new MedialFile() { sn = 19, path = prefix + basePath+ mediapath + @"\021.m4a", name = "資產負債表" });
            mediafiles.Add(new MedialFile() { sn = 20, path = prefix + basePath + mediapath + @"\022.m4a", name = "結算後帳務產出" });
        }
        public void PlayMedialData(int sn, bool play)
        {

            if (media != null)
            {
                media.controls.stop();
                media.close();
              //  media.Disconnect();
            }
            media = new WindowsMediaPlayer();
            media.URL = mediafiles[sn + 1].path;
            if (play)
            {
                media.controls.play();
                WMPPlayState data = media.playState;
            }
            else
                media.controls.stop();
        }

        public void PlayMedialDataList(int sn, bool play)
        {
          
            if (media != null)
            {
                media.controls.stop();
                media.close();
                //  media.Disconnect();
            }
          
            media.currentPlaylist.clear();          
            WindowsMediaPlayer media01 = new WindowsMediaPlayer();
            media01.URL = mediafiles[sn + 1].path;
            WindowsMediaPlayer media02 = new WindowsMediaPlayer();
            media02.URL = mediafiles[sn + 2].path;
            media.currentPlaylist.appendItem(media01.currentMedia);
            media.currentPlaylist.appendItem(media02.currentMedia);
            media.settings.autoStart = true;
            if (play)
            {
                media.controls.play();
            }
            else
                media.controls.stop();
        }
    }
}
