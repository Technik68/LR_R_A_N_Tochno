using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_R_A_N_Tochno
{
    public interface ITrafficLightState
    {
        void ChangeState(TrafficLight trafficLight, int b, int z);
        int SetB1(int b, int z);
        int SetW1(int b, int z);
    }
}
