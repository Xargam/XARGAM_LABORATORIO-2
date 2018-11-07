namespace Ejercicio_48
{
	public class Recibo : Documento
	{
		#region Constructor
		public Recibo() : this(int.Parse("0"))
		{

		}
		public Recibo(int numero) : base(numero)
		{

		} 
		#endregion
	}
}
