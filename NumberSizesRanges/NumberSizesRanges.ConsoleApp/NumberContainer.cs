namespace NumberSizesRanges.ConsoleApp
{
    internal class NumberContainer
    {
        private readonly string _alias;
        private readonly byte _bytesOfMemory;
        private readonly string _min;
        private readonly string _max;

        public NumberContainer(string alias, byte bytes, string min, string max)
        {
            _alias = alias;
            _bytesOfMemory = bytes;
            _min = min;
            _max = max;
        }

        public string Alias 
        {
            get => _alias;
        }
        public byte BytesOfMemory 
        {
            get => _bytesOfMemory; 
        }
        public string Min 
        {
            get => _min;
        }
        public string Max 
        {
            get => _max;
        }

    }
}
