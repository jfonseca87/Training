using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaWBootstrap_Table.Models
{
    public class Empleado
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Salario { get; set; }

        public List<Empleado> cargarLista()
        {
            List<Empleado> lstEmpleado = new List<Empleado>();

            lstEmpleado.Add(new Empleado { Id = "001", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "002", Nombre = "Alberto", Pais = "India", Salario = "20000" });
            lstEmpleado.Add(new Empleado { Id = "002", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "003", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "004", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "005", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "006", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "007", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "008", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "009", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0010", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0011", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0012", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0013", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0014", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0015", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0016", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0017", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0018", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0019", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0020", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0021", Nombre = "Anusha", Pais = "India", Salario = "10000" });
            lstEmpleado.Add(new Empleado { Id = "0022", Nombre = "Anusha", Pais = "India", Salario = "10000" });

            return lstEmpleado;
        }
    }
}