namespace BitConverter
{
    public delegate void MiDelegado(string hola);

    public class Class1
    {
        public event MiDelegado eventito;
        public string Mostrar()
        {
            this.eventito += new MiDelegado(this.Hola);
            this.eventito("fsd");
            return "";
        }
        public void Hola(string hoteleria)
        {
            System.Console.WriteLine(hoteleria);
        }

        public void Hola2(string hoteleria, string d)
        {
            System.Console.WriteLine(hoteleria);
        }
    }
}
