class Potravina
{
    public string Nazev { get; set; }
    public double Hmotnost { get; set; }
    public double EnergetickaHodnotaKJ { get; set; }

    public double EnergetickaHodnotaKcal
    {
        get { return EnergetickaHodnotaKJ / 4.184; }
        set { EnergetickaHodnotaKJ = value * 4.184; }
    }

    public double ProcentDennihoMinKalorickehoPrijmu(double denniMinPrijemKcal)
    {
        return (EnergetickaHodnotaKcal / denniMinPrijemKcal) * 100;
    }
}

