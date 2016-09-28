
namespace MultiLearn.Input
{
    public enum SpecialKeys
    {
        Backspace, Enter, Escape, None
    }

    public class InputData
    {
        public char Data
        {
            get { return this._data; }
        }
        private char _data;

        public ushort RawData
        {
            get { return this._rawData; }
        }
        private ushort _rawData;

        public int NumericData
        {
            get
            {
                if (this.IsNumeric())
                {
                    return this._data - '0';
                }
                else
                {
                    return -1;
                }
            }
        }

        public SpecialKeys SpecialKey
        {
            get { return this._specialKey; }
        }
        private SpecialKeys _specialKey;

        public InputData(char data)
        {
            this._data = data;
        }

        public InputData(ushort keyCode)
        {
            this._rawData = keyCode;
            this._specialKey = SpecialKeys.None;
            if ((keyCode > 47) && (keyCode < 59))
            {
                this._data = (char) (keyCode - 48 + '0');
            }
            else if ((keyCode > 95) && (keyCode < 106))
            {
                this._data = (char) (keyCode - 96 + '0');
            }
            else if ((keyCode > 64) && (keyCode < 91))
            {
                this._data = (char)(keyCode - 65 + 'A');
            }
            else if (keyCode == 8)
            {
                this._specialKey = SpecialKeys.Backspace;
            }
            else if (keyCode == 13)
            {
                this._specialKey = SpecialKeys.Enter;
            }
            else if (keyCode == 27)
            {
                this._specialKey = SpecialKeys.Escape;
            }
        }

        public bool IsNumeric()
        {
            return this._data >= '0' && this._data <= '9';
        }
    }
}
