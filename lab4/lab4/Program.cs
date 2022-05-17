GES a = GES.getInstance();
a.DistrictGES = "Московский";
a.NumberGES = 11;
a.Residents = 5;
a.GESTariffOn();
a.DecreaseGesTariff(1);
a.Payment = 1;
a.ResidentsPay = 3;
double ans = a.Debt();
Console.WriteLine(ans);
public class Tariff
{
    private int currentTariff;
    public int CurrentTariff
    {
        get { return currentTariff; }
    }

    private bool isTariff;
    public bool IsTariff
    {
        get { return isTariff; }
    }

    public Tariff()
    {
        isTariff = false;
        currentTariff = 0;
    }

    public Tariff(int tariff)
    {
        currentTariff=tariff;
        isTariff=true;
    }

    public Tariff(int tariff, bool isOnOff)
    {
        isTariff=isOnOff;
        if (isOnOff) { currentTariff = tariff; }
        else { currentTariff = 0; }
    }
    public void TariffOn()
    {
        isTariff = true;
    }

    public void TariffOff()
    {
        isTariff = false;
    }

    public void IncreaseTariff(int value)
    {
        if (isTariff) { currentTariff += value; }
    }

    public void DecreaseTariff(int value)
    {
        if (isTariff) { currentTariff -= value; }
    }
}

public class GES
{
    private Tariff gesTariff;

    private static GES instance;

    private GES()
    {
        gesTariff = new Tariff(45);
    }
    public static GES getInstance()     //реализация шаблона проектирования Singleton
    {
        if (instance == null) { instance = new GES(); } 
        return instance;
    }

    private int numberGES;
    public int NumberGES
    {
        get { return numberGES; }
        set { numberGES = value; }
    }

    private string districtGES;
    public string DistrictGES
    {
        get { return districtGES; }   
        set { districtGES = value; }
    }

    public double GESCurrentTariff
    {
        get { return gesTariff.CurrentTariff; }
    }

    public bool isGESTariffOn 
    {
        get { return gesTariff.IsTariff; }   
    }
    public void GESTariffOn()
    {
        gesTariff.TariffOn();
    }
    public void GESTariffOff()
    {
        gesTariff.TariffOff();
    }
    public void IncreaseGesTariff(int value)
    {
        gesTariff.IncreaseTariff(value);
    }
    public void DecreaseGesTariff(int value)
    {
        gesTariff.DecreaseTariff(value);
    }

    private int residents;
    public int Residents
    {
        get { return residents; }
        set { residents = value; }
    }

    private double payment;
    public double Payment
    {
        get { return payment; }
        set { payment = value * GESCurrentTariff; }
    }

    private int residentsPay;
    public int ResidentsPay
    {
        get { return residentsPay; }
        set { residentsPay = value; }
    }

    static double debt = 0;
    public double Debt()
    {
        debt = payment * (residents - residentsPay);
        return debt;
    }
}