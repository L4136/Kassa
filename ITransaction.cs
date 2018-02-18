using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kassa
{
    
    public interface ITransaction
    {
        // interface members 
        string ShowTransaction(float Money);
        float GetAmount();
    }
}
