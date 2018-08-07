namespace FacElec.model
{
    public class cliente
    {
        public int id_Cliente;
        public string nombre_encargado;
        public string telefono;
        public string nombre;
        public string email;
        public string direccion;
        public int provincia;
        public int canton;
        public int distrito;
        public string idautomercado;

        public cliente(int id_Cliente, string nombre_encargado, string telefono, string nombre, string email, string direccion,
                       int provincia, int canton, int distrito, string idautomercado)
        {
            this.id_Cliente = id_Cliente;
            this.nombre_encargado = nombre_encargado;
            this.telefono = telefono;
            this.nombre = nombre;
            this.email = email;
            this.direccion = direccion;
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.idautomercado = idautomercado;
        }
    }
}