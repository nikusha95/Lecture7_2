using Enums.EnumMembers;

namespace Enums
{
    public class Car
    {
        private readonly string _mark;
        private readonly string _model;
        private readonly CarType _type;
        private int _speed;
        private const int MaxSpeed = 300;

        public Car(string mark, string model, CarType type, int speed = 200)
        {
            _mark = mark;
            _model = model;
            _type = type;
            _speed = speed;
        }

        public void SetSpeed(int speed)
        {
            if (speed > MaxSpeed)
            {
                return;
            }

            _speed = speed;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"mark {_mark}\nmodel {_model}\ntype {_type}\nspeed {_speed}");
        }
    }
}