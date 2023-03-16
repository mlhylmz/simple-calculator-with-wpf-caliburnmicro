using Caliburn.Micro;
using System;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Diagnostics;

namespace CMCalcculator.ViewModels
{
    public class ShellViewModel : Screen
    {
        private double _input;
        private double _result;

        public double Input
        {
            get => _input;
            set
            {
                _input = value;
                NotifyOfPropertyChange(()=> Input);
                NotifyOfPropertyChange(()=> CansumButton);
                NotifyOfPropertyChange(()=> CandecButton);
                NotifyOfPropertyChange(()=> CanmultiButton);
                NotifyOfPropertyChange(()=> CandivideButton);
            }
        }

        public double Result
        {
            get => _result;
            set
            {
                _result = value;
                NotifyOfPropertyChange(() => Result);
            }
        }

        public void changeInput(int val)
        {
            Input = (_input * 10) + val;
        }


        public void One()
        {
            changeInput(1);

        }
        public void Two()
        {
            changeInput(2);
        }
        public void Three()
        {
            changeInput(3);
        }
        public void Four()
        {
            changeInput(4);
        }
        public void Five()
        {
            changeInput(5);
        }
        public void Six()
        {
            changeInput(6);
        }
        public void Seven()
        {
            changeInput(7);
        }
        public void Eight()
        {
            changeInput(8);
        }
        public void Nine()
        {
            changeInput(9);
        }
        public void Zero()
        {
            changeInput(0);
        }

        public void clearInput()
        {
            Input = 0;
        }

        public void clearAll()
        {
            Result = 0;
            Input = 0;
        }

        public void delOneLine()
        {
            Input = Input - (Input % 10);
            Input = Input / 10;
        }

        public void sumButton()
        {
            Result += Input;
            clearInput();
        }

        public void decButton()
        {
            Result -= Input;
            clearInput();
        }

        public void multiButton()
        {
            Result *= Input;
            clearInput();
        }

        public void divideButton()
        {
            Result /= Input;
            clearInput();
        }

        public bool CansumButton
        {
            get => (Input > 0);
        }
        public bool CandecButton
        {
            get => (Input > 0);
        }
        public bool CanmultiButton
        {
            get => (Input > 0);
        }
        public bool CandivideButton
        {
            get => (Input > 0);
        }




    }
}
