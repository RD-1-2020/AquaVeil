namespace AquaVeilV1.DataSenders
{
    interface IDataSender
    {
        public string Connect();

        public void SendData(string response);
    }
}
