using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_R_A_N_Tochno
{
    public class TrafficLight
    {
        public ITrafficLightState CurrentState { get; set; }
        public int B1 { get; set; }
        public int W1 { get; set; }
        public TrafficLight()
        {
            // Начальное состояние: красный свет
            CurrentState = new State_B1Z1();
        }

        public void Change(int b1, int z1)
        {
            // Метод изменения состояния светофора
            CurrentState.ChangeState(this, b1, z1);
        }


    }
}
