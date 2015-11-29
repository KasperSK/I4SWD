using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineSwitchCase
{
    public class FlashLightSwitchCase
    {
        public enum FlashLightStates
        {
            On,
            Off
        };

        public enum FlashLightEvents
        {
            Power
        };

        private FlashLightStates _state;

        private void TurnOn()
        {
            Console.WriteLine("Lamp on!");
        }

        private void TurnOff()
        {
            Console.WriteLine("Lamp Off!");
        }

        public FlashLightSwitchCase()
        {
            _state = FlashLightStates.Off;
        }

        public void HandleEvent(FlashLightEvents ev)
        {
            switch (_state)
            {
                    case FlashLightStates.Off:
                        _state = FlashLightStates.On;
                        TurnOn();
                        break;
                    case FlashLightStates.On:
                        _state = FlashLightStates.Off;
                        TurnOff();
                        break;
            }
        }
    }
}
