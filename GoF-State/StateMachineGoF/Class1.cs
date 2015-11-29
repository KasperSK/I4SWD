using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineGoF
{
    public class FlashLightContext
    {
        private FlashLightState _state;

        public FlashLightContext()
        {
           SetState(new Off());
        }

        public void SetState(FlashLightState state)
        {
            _state = state;
            _state.OnEnter(this);
        }

        public void EventPower()
        {
            _state.HandlePowerEvent(this);
        }

        public void TurnOn()
        {
            Console.WriteLine("Lamp On!!" + Environment.NewLine);
        }

        public void TurnOff()
        {
            Console.WriteLine("Lamp Off!" + Environment.NewLine);
        }
    }

    public class FlashLightState
    {

        public virtual void OnEnter(FlashLightContext context)
        {
            
        }

        public virtual void OnExit()
        {
            
        }

        public virtual void HandlePowerEvent(FlashLightContext context)
        {
            
        }
    }

    public class On : FlashLightState
    {
        public override void HandlePowerEvent(FlashLightContext context)
        {
            context.SetState(new Off());
        }
    }

    public class Off : FlashLightState
    {
        public override void HandlePowerEvent(FlashLightContext context)
        {
            context.TurnOn();
            context.SetState(new On());
        }

        public override void OnEnter(FlashLightContext context)
        {
            context.TurnOff();
        }
    }
}
