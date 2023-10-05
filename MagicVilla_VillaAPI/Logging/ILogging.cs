namespace MagicVilla_VillaAPI.Logging
{
    public interface ILogging
    {
        /* Type: Error, Information, etc
         */
        public void Log(string message, string type);
    }
}
