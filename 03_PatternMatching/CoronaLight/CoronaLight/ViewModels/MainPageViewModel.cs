using CoronaLight.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Linq;
using static CoronaLight.Models.LightState;

namespace CoronaLight.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private readonly LightInput _lightInput = new LightInput();

        public MainPageViewModel()
        {
            _lightInput.PropertyChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(LightState));
                //var propertyNames = new[] { "Reproduction", "SickPer1000", "HospitalUtilization" };
                //if (propertyNames.Contains(e.PropertyName))
                //{
                //    OnPropertyChanged(nameof(LightState));
                //}

            };

        }

        public LightInput LightInput => _lightInput;

        public LightState LightState
        {
            get
            {
                LightState lightState = GetLightState(_lightInput);
                if (_lightInput.PoliticalInfluence < 50)
                {
                    return lightState;
                }
                else
                {
                    return GetLightStateWithPoliticalInfluence(lightState);
                }
            }
        }

        private LightState GetLightState(LightInput lightInput) =>
            lightInput switch
            {
                { Reproduction: < 0.5, SickPer1000: < 10, HospitalUtilization: < 5 }  => Green,
                { Reproduction: < 1.1, SickPer1000: < 100, HospitalUtilization: < 20 } => Yellow,
                { Reproduction: < 2, SickPer1000: < 1000, HospitalUtilization: < 40 } => Orange,
                _ => Red
            };

        private LightState GetLightStateWithPoliticalInfluence(LightState lightState) =>
            lightState switch
            {
                Red => Orange,
                Orange => Yellow,
                Yellow => Green,
                _ => Green
            };
    

        private bool _isAdvanced;
        public bool IsAdvanced
        {
            get => _isAdvanced;
            set => SetProperty(ref _isAdvanced, value);
        }
    }
}
