using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_R_A_N_Tochno
{
    class State_B4Z3 : ITrafficLightState
    {
        public void ChangeState(TrafficLight trafficLight, int b, int z)
        {
            trafficLight.CurrentState = new State_B4Z4();
            trafficLight.B1 = SetB1(b, z);
            trafficLight.W1 = SetW1(b, z);


        }

        public int SetB1(int b, int z)
        {

            if (b == 4 && z == 3)
                return 0;
            else return 0;
        }
        public int SetW1(int b, int z)
        {

            if (b == 4 && z == 3)
                return 2;
            else return 0;
        }
    }
}
