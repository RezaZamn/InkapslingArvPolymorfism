using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapslingArvPolymorfism
{
    abstract class UserError
    {
       public abstract string UEMessage();
     
    }

    internal class EgenKlass1() : UserError
    {
        public override string UEMessage()
        {
            return "This is error One";
        }
    }

    internal class EgenKlass2() : UserError
    {
        public override string UEMessage()
        {
            return "This is error Two";
        }
    }


    internal class EgenKlass3() : UserError
    {
        public override string UEMessage()
        {
            return "This is error Three";
        }
    }
}
