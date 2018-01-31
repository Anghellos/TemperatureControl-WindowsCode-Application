using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public int Priority { get; private set; }
        public string Name { get; private set; }
        public int OptimTemp { get; private set; }

        //========================================Methods=========================================//

        public void SetPriority(int value)
        {
            Priority = value;
        }

        public void SetName(string value)
        {
            Name = value;
        }

        public void SetOptimTemp(int value)
        {
            OptimTemp = value;
        }
    }
}
