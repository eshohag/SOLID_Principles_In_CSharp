using InterfaceSegregationPrinciple.Interface;

namespace InterfaceSegregationPrinciple
{
    class MultiFunctionalVehicle : IMultiFunctionalVehicle
    {
        private readonly ICar _car;
        private readonly IAirplane _airplane;

        public MultiFunctionalVehicle(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }

        public void Drive()
        {
            _car.Drive();
        }

        public void Fly()
        {
            _airplane.Fly();
        }
    }
}
