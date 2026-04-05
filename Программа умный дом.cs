using System;

class Lighting
{
    public void TurnOn()
    {
        Console.WriteLine("Свет везде включен.");
    }
    public void TurnOff()
    {
        Console.WriteLine("Свет везде выключен.");
    }
}
class ClimateControl
{
    public void TurnOn()
    {
        Console.WriteLine("Умный увлажнитель и кондиционер включены.");
    }
    public void TurnOff()
    {
        Console.WriteLine("Умный увлажнитель и кондиционер выключены.");
    }
}
class Security
{
    public void TurnOn()
    {
        Console.WriteLine("Умная сигнализация и датчики движения включены.");
    }
    public void TurnOff()
    {
        Console.WriteLine("Умная сигнализация и датчики движения выключены.");
    }
}
class Media
{
    public void TurnOn()
    {
        Console.WriteLine("Звуковая аппаратура включена.");
    }
    public void TurnOff()
    {
        Console.WriteLine("Звуковая аппаратура выключена.");
    }
}
class  GaradgeDoor
{
    public void TurnOn()
    {
        Console.WriteLine("Гаражная дверь включена");
    }
    public void TurnOff()
    {
        Console.WriteLine("Гаражная дверь выключена");
    }
}
public class HomeFacade
{
    private Lighting _lighting;
    private Security _security;
    private Media _media;
    private ClimateControl _control;
    private GaradgeDoor _door;
    public HomeFacade()
    {
        _lighting = new Lighting();
        _control = new ClimateControl();
        _security = new Security();
        _media = new Media();
        _door = new GaradgeDoor();
    }
    public void LeaveHome()
    {
        Console.WriteLine("Система я ухожу включена.");
        _lighting.TurnOff();
        _control.TurnOff();
        _security.TurnOn();
        _media.TurnOff();
        _door.TurnOff();
        Console.WriteLine("Система я ухожу успешно включена и готова к работе.");
    }
    public void ReturnHome()
    {
        Console.WriteLine("Система я ухожу выключена.");
        _lighting.TurnOn();
        _control.TurnOn();
        _security.TurnOff();
        _media.TurnOn();
        _door.TurnOn();
        Console.WriteLine("____");
        Console.WriteLine("Джарвис: даже Тони Старк позавидовал бы такому.");
        Console.WriteLine("_____");
    }
    class Program
    {
        static void Main(string[] args)
        {
            HomeFacade home = new HomeFacade();
            home.LeaveHome();
            home.ReturnHome();

            Console.WriteLine("Для выхода требуется подтвердить личность отпечатком пальца.");
            Console.WriteLine("Под защитой dimkiy777 heh)");
            Console.ReadKey();
        }
    }
}