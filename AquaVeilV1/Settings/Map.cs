namespace AquaVeilV1.Settings
{
    public class Map
    {
        public uint _numInCanvas { get; set; }

        public uint _addres { get; set; }

        public Map()
        {
        }

        public Map(uint numInCanvas, uint addres)
        {
            this._numInCanvas = numInCanvas;
            this._addres = addres;
        }
    }
}