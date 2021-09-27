using System;
using System.Collections.Generic;
using System.Text;

namespace Palmer_TargetHeartRateCalculator
{
    class TargetHeartRate
    {
        private int _age;
        private int _thr;
        private double _modLowRate;
        private double _modHighRate;
        private double _vigLowRate;
        private double _vigHighRate;
        double mLo = .5;
        double mHi = .7;
        double vLo = .7;
        double vHi = .85;
        
        public TargetHeartRate(int age)
        {
            _age = age;
            if (validAge(age))
            {
                
                _thr = 220 - _age;
                _modLowRate = Math.Round((_thr * mLo), 0, MidpointRounding.AwayFromZero);
                _modHighRate = Math.Round((_thr * mHi), 0, MidpointRounding.AwayFromZero);
                _vigLowRate = Math.Round((_thr * vLo), 0, MidpointRounding.AwayFromZero);
                _vigHighRate = Math.Round((_thr * vHi), 0, MidpointRounding.AwayFromZero);
            }
        }
        public TargetHeartRate()
        {
            _age = 0;
        }

        // Getter & Setter Properties
        public int Age
        {
            // if using try catch then change and use this to set error message
            get { return _age; }
            set 
            { if (value < 0 && value > 101)
                {
                    _age = value;
                    _thr = 220 - _age;
                }
            }
        }
        public int THR
        {
            get { return _thr; }
        }
        public int ModLow
        {
            get { return (int)_modLowRate; }
        }
        public int ModHigh
        {
            get { return (int)_modHighRate; }
        }
        public int VigLow
        {
            get { return (int)_vigLowRate; }
        }
        public int VigHigh
        {
            get { return (int)_vigHighRate; }
        }
        private bool validAge(int age)
        {
            // not using try catch && the data will be validate before class 
            // is instantiated if that were not the case
            // then this method would set the error message to send back 
            bool valid;
            if (age > 0 && age < 101)
                valid = true;
            else
                valid = false;
            return valid;
        }

    }
}
