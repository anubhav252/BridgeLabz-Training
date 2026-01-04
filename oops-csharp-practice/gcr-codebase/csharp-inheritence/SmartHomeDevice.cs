using System;

class Device{
    protected int DeviceId;
    protected string Status;

    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID : " + DeviceId);
        Console.WriteLine("Status    : " + Status);
    }
}

class Thermostat : Device{
    private int TemperatureSetting;

    public Thermostat(int deviceId, string status, int temperatureSetting)
        : base(deviceId, status){
        TemperatureSetting = temperatureSetting;
    }

    public override void DisplayStatus(){
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting : " + TemperatureSetting + "°C");
    }
}

class SmartHomeDevice{
    static void Main(string[] args)
    {
        Device device = new Thermostat(101, "ON", 24);
        device.DisplayStatus();
    }
}
