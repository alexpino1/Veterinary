using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterenary.Shared.Entities
{
    public class Owner
    {
        [required(ErrorMessage = "El ID Es requerido")]
        public int Id { get; set; }
        [required(ErrorMessage = "El Documento Es requerido")]
        public string Document { get; set; } = null;
        [required(ErrorMessage = "El Nombre Es requerido")]
        public string FirtsName { get; set; } = null;
        [required(ErrorMessage = "El Apellido Es requerido")]
        public string LastName { get; set; } = null;
        [required(ErrorMessage = "El phone Es requerido")]
        public string Fixedphone { get; set; } = null;
        [required(ErrorMessage = "El celular Es requerido")]
        public string Cellphone { get; set; } = null;
        [required(ErrorMessage = "El Direccion Es requerido")]
        public string Address { get; set; } = null;
        public string FullName => $"{FirtsName}{LastName}";






    }
}
