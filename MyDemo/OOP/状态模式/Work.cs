using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Work
    {
        private WorkState _state { get; set; }

        public int Hour { get; set; }

        public bool IsFinished { get; set; }
        

        public Work()
        {
            _state = new NoonWorkState();
            Hour = DateTime.Now.Hour;
        }

        public void SetState(WorkState state)
        {
            _state = state;
        }


        public void WriteProgram()
        {
            _state.WriteProgram(this);
        }
    }
}
