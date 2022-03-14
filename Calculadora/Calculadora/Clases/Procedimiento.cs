using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class Procedimiento
    {
        private double valor1;
        private double valor2;
        private char operacion;
        private double resultado = 0;
        public double Valor1 { set => valor1 = value;  }
        public double Valor2 { set => valor2 = value;  }
        public char Operacion { set => operacion = value;  }
        public double Resultado { get => resultado;  }

        //Metodos

        public void SOperacion()
        {
            switch (operacion)
            {
                case '+':
                    resultado = valor1 + valor2;
                    break;
                case '-':
                    resultado = valor1 - valor2;
                    break;
                case '*':
                    resultado = valor1 * valor2;
                    break;
                case '/':
                    resultado =  valor1 / valor2;
                    break;
                
            }
        }
       
    }
}
