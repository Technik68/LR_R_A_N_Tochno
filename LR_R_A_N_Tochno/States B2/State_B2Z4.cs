using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_R_A_N_Tochno
{
    class State_B2Z4 : ITrafficLightState
    {
        public void ChangeState(TrafficLight trafficLight, int b, int z)
        {
            trafficLight.CurrentState = new State_B2Z5();
            trafficLight.B1 = SetB1(b, z);
            trafficLight.W1 = SetW1(b, z);


        }

        public int SetB1(int b, int z)
        {

            if (b == 2 && z == 4)
                return 2;
            else return 0;
        }
        public int SetW1(int b, int z)
        {

            if (b == 2 && z == 4)
                return 0;
            else return 0;
        }
    }
}
