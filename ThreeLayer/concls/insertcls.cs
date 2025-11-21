using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace concls
{
    public class insertcls
    {
        conncls objdal = new conncls();
        public int insertfn(string na,int ag, string addr,string phn,string una,string pswd)
        {
            string s = "insert into Reg values('" + na + "'," + ag + ",'" + addr + "'," + phn + ",'" + una + "','" + pswd + "')";
            int i = objdal.fun_Nonquery(s);
            return i;
        
        }



    }
}
