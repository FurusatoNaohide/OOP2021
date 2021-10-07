﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SendMail
{
    [Serializable]
    public class Settings
    {
        private static Settings instance = null;
        public static string FileName = "mailsettings.xml";
        public static bool FileCheack = false;

        public int Port { get; set; }   //ポート番号
        public string Host { get; set; }     //ホスト名
        public string MailAddr { get; set; } //メールアドレス
        public string Pass { get; set; }     //パスワード
        public bool Ssl { get; set; }   //SSL

        //コンストラクタ
        private Settings()
        {
            
        }

        //インスタンスの取得(1回のみ) ここから参照
        public static Settings getInstance()
        {
            if (instance == null)
            {
                instance = new Settings();
                
                
                //XMLファイルを読み込み（逆シリアル化）【P303参照】
                using (var reader = XmlReader.Create(FileName))
                {
                    var serializer = new DataContractSerializer(typeof(Settings));
                    var set = serializer.ReadObject(reader) as Settings;

                    instance.Host = set.Host;
                    instance.Port = set.Port;
                    instance.MailAddr = set.MailAddr;
                    instance.Pass = set.Pass;
                    instance.Ssl = set.Ssl;
                }
                
            }
            return instance;
        }

        //送信データ登録
        public void setSendConfig(string host,int port,string mailAddr,
                                  string pass,bool ssl)
        {
            Host = host;
            Port = port;
            MailAddr = mailAddr;
            Pass = pass;
            Ssl = ssl;

            //XMLファイルへ書き出し（シリアル化）【P302参照】
            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "   ",
            };

            using (var writer = XmlWriter.Create(FileName, xws))
            {
                var serialier = new DataContractSerializer(this.GetType());
                serialier.WriteObject(writer, this);
            }
        }

        //初期値
        public string sHost()
        {
            return "smtp.gmail.com";
        }

        public string sPort()
        {
            return 587.ToString();
        }

        public string sMailAddr()
        {
            return "ojsinfosys01@gmail.com";
        }

        public string sPass()
        {
            return "Infosys2021";
        }
        public bool bSsl()
        {
            return true;
        }

        public static bool setDataCheck()
        {
            if (FileCheack)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
