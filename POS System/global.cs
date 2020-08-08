using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    class global
    {
        private static string logUser = "user";
        private static string logPass = "1234";
        public static string log_User
            {
            get{return logUser;}
            set { logUser = value; }
            }
        public static string log_Pass
        {
            get { return logPass; }
            set { logPass = value; }
        }
        private static int tot = 0;
        public static int vartot
        {
            get { return tot; }
            set { tot = value; }
        }

        private static int qty = 0;
        public static int varqty
        {
            get { return qty; }
            set { qty = value; }
        }

        private static string vtitle = "POS System";
        public static string title
        {
            get { return vtitle; }
            set { vtitle = value; }
        }
    }
}
