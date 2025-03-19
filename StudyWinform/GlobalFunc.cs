using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWinform
{
    internal class GlobalFunc
    {
        private static GlobalFunc _Instance = null;

        public static GlobalFunc Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new GlobalFunc();
                }
                return _Instance;
            }
        }

        public string AcountG = null;
        public Form1 formLogin = null;


    }
}
