using System;
using System.Collections.Generic;
using System.Text;

namespace Structs_Enums
{
    public struct Empleado
    {
        private double salarioBase;
        private double comision;

        public Empleado(double salarioBase, double comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public void CambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }

        public override string ToString()
        {
            return $"Salario del empleado: {this.salarioBase}, Comisión del empleado: {this.comision}";
        }
    }
}
