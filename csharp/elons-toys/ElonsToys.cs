using System;

class RemoteControlCar
{
    private long _distance = 0;   //Meters
    private float _batteryLevel = 100f;

    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return string.Format($"Driven {_distance} meters");
    }

    public string BatteryDisplay()
    {
        if (_batteryLevel == 0)
        {
            return "Battery empty";
        }else{
            return string.Format($"Battery at {_batteryLevel}%");
        }
    }

    public void Drive()
    {
        if (_batteryLevel == 0)
        {
            Console.WriteLine("Battery empty");
        }else{
            _batteryLevel--;
            _distance += 20;
            Console.WriteLine("Se encuentra conduciendo");
        }
    }
}
