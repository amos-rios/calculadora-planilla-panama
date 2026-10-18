using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPlanilla
{
    public class Empleado
    {
        private string nombre;
        private string cedula;
        private double salarioBruto;

        private double seguroSocial, seguroEducativo, salarioNeto;

        public Empleado(string nombre, string cedula, double salarioBruto)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.salarioBruto = salarioBruto;
        }

        public double CalcularSeguroSocial()
        {
            seguroSocial = salarioBruto * 0.0975;
            return seguroSocial;
        }

        public double CalcularSeguroEducativo()
        {
            seguroEducativo = salarioBruto * 0.0125;
            return seguroEducativo;
        }

        public double CalcularSalarioNeto()
        {
            seguroSocial = CalcularSeguroSocial();
            seguroEducativo = CalcularSeguroEducativo();
            salarioNeto = salarioBruto - seguroSocial - seguroEducativo;
            return salarioNeto;
        }
    }
}

