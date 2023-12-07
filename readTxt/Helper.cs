using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readTxt
{
    public class Helper
    {
        private readonly static Helper _instance=new Helper();

        public static Helper Instance => _instance;

        public string[]MessagesList { get; set; }
        private Helper()
        {
            //טעינת הודעות מקובץ
        }

    }
}
