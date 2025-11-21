using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace concls
{
   public class Login
    {
        concls objdal = new concls();
    }

    public string getcountid(string una,string pswd)
    {
        string str = "select count(id) from Reg where Username='" + una + "' and password='" + pswd + "'";
        string cid = objdal.fun_scalar(str);
        return cid;
    
    }
}
