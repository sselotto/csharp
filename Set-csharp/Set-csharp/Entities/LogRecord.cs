using System;

namespace Set_csharp.Entities
{
    class LogRecord
    {
        //Propriedades
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is LogRecord)) //Programação defensiva
            {
                return false;
            }
            LogRecord other = obj as LogRecord; //DownCasting

            return Username.Equals(other.Username);
        }
    }
}
