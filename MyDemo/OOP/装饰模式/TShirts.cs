using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class TShirts:Finery
    {
        public override void Show()
        {
            Console.Write("大T恤");
            base.Show();
        }
    }
}
