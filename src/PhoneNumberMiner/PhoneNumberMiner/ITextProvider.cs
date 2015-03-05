using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberMiner
{
    public interface ITextProvider
    {
        string Read(string address);
    }
}
