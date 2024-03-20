using System.Text.Json;

namespace BMI
{
    internal class BMI(double Peso, double Altezza)
    {
        public double Indice { get => Peso / Math.Pow(Altezza, 2); }

        public string Stato
        { 
            get {
                switch (Indice)
                {
                    case < 18.5:
                        return "Sottopeso";
                    case >= 18.5 and <= 24.9:
                        return "Normopeso";
                    case > 24.9 and < 30:
                        return "Sovrappeso";
                    default:
                        return "Obeso";
                }
            } 
        }

        public string Stringify() => JsonSerializer.Serialize(this);
    }
}