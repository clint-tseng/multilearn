using System;
using System.Collections.Generic;

namespace MultiLearn.Input
{
    public delegate void InputOccurredEventHandler(object sender, InputOccurredEventArgs e);

    public class InputOccurredEventArgs : EventArgs
    {
        public InputData InputData
        {
            get { return this._inputData; }
        }
        private InputData _inputData;

        public InputOccurredEventArgs(InputData inputData)
        {
            this._inputData = inputData;
        }
    }

    public delegate void InputReadyEventHandler(object sender, InputReadyEventArgs e);

    public class InputReadyEventArgs : EventArgs
    {
        public List<InputProxy> Proxies
        {
            get { return this._proxies; }
        }
        private List<InputProxy> _proxies;

        public InputReadyEventArgs(List<InputProxy> proxies)
        {
            this._proxies = proxies;
        }
    }

    public interface InputLayer
    {
        event InputReadyEventHandler InputReady;
        event InputOccurredEventHandler InputOccurred;

        void Initialize();
    }
}
