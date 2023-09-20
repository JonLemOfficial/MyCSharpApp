using System;

namespace MyCSharpApp.Desktop.Models
{
    public class ProductsModel
    {
        public ProductTransaction[] HDR;
        public ProductDetail[] Line;
    }


    public class ProductTransaction
    {
        public string Id_Transaccion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string CodSucursalOrigen { get; set; }
        public string CodAlmacenOrigen { get; set; }
        public string CodSucursalDestino { get; set; }
        public string CodAlmacenDestino { get; set; }
    }

    public class ProductDetail
    {
        public string Id_Transaccion { get; set; }
        public string CodArticulo { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
        public bool Disponible { get; set; }
        public decimal Precio { get; set; }

    }
}
