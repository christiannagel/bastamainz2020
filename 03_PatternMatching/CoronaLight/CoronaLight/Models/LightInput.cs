using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace CoronaLight.Models
{
    public class LightInput : ObservableObject
    {
        private double _reproduction;

        public double Reproduction
        {
            get => _reproduction;
            set => SetProperty(ref _reproduction, value);
        }

        private int _sickPer1000;

        public int SickPer1000
        {
            get => _sickPer1000;
            set => SetProperty(ref _sickPer1000, value);
        }

        private int _hospitalUtilization;

        public int HospitalUtilization
        {
            get => _hospitalUtilization;
            set => SetProperty(ref _hospitalUtilization, value);
        }

        private int _politicalInfluence;

        public int PoliticalInfluence
        {
            get => _politicalInfluence;
            set => SetProperty(ref _politicalInfluence, value);
        }
    }
}
