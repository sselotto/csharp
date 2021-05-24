

namespace GetHashCode_Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Client)) //Programação defensiva
            {
                return false;
            }
            Client other = obj as Client; //DownCasting
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }

    }
        
}
