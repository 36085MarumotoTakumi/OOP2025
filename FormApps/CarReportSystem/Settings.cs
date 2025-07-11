using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarReportSystem {
    public class Settings {

        private static Settings instance; //自分自身のインスタンスを格納

        //設定した色情報を格納
        public int MainFormColor { get; set; }

        //コンストラクタ(privateにすることでnewできなくなる)
        private Settings() { }

        public static Settings getInstance() {
            if (instance == null) {
                instance = new Settings();
            }
            return instance;
        }
    }
}
