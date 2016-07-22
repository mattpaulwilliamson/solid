namespace BreakingInterfaceSegregationPrinciple
{
    public class LuxuryCar : IVehicle, IHaveARadio, IHaveASunRoof
    {
        private bool _radioOn;

        public void Accelerate(){ 
            // do something to make car go faster
        }

        public void Brake(){
            //do something to make car slow down
        }

        public void ChangeGear(int gear){
            // change to selected gear
        }

        public void TurnOnRadio(){
            _radioOn = true;
        }
        public void TurnOffRadio(){
            _radioOn = false;
        }

        public void OpenSunRoof(int percentOpen){
            //Open sunroof to requested amount
        }

        public void CloseSunRoof(){
            //Make sunroof 100% shut (0% open)
        }
    }

    public class MotorCycle : IVehicle
    {
        public void Accelerate()
        {
            // do something to make Bike go faster 
        }

        public void Brake()
        {
            // do something to make Bike slow down 
        }

        public void ChangeGear(int gear)
        {
            //change to selected gear...remember that bikes have a sequential gear box!
        }
    }

    public class BudgetCar : IVehicle, IHaveARadio
    {
        private bool _radioOn;

        public void Accelerate()
        {
            // do something to make car go faster
        }

        public void Brake()
        {
            //do something to make car slow down
        }

        public void ChangeGear(int gear)
        {
            // change to selected gear
        }

        public void TurnOnRadio()
        {
            _radioOn = true;
        }
        public void TurnOffRadio()
        {
            _radioOn = false;
        }
    }
}