namespace FacElec.model
{
    public class Env
    {
        public int account;
        public string email;
        public string password;

        public Env(int account, string email, string password)
        {
            this.account = account;
            this.email = email;
            this.password = password;
        }

        public override string ToString(){
            return $"Ambiente. Cuenta: {this.account}, Email: {this.email}";
        }
    }
}