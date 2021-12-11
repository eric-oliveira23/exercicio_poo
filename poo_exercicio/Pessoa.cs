using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_exercicio
{
    class Pessoa
    {
        public double peso, altura;
        

        public double imc()
        {
            return peso / (altura * altura);
        }

        public string resulImc(double imc)
        {
            string retorno;

            if (imc < 18.5)
            {
                retorno = "Abaixo do peso.";
            }
            else if (imc < 25)
            {
                retorno = "Peso normal";
            }
            else if (imc < 30)
            {
                retorno = "Acima do peso.";
            }
            else if (imc < 35)
            {
                retorno = "Obesidade I";
            }
            else if (imc < 40)
            {
                retorno = "Obesidade II";
            }
            else 
            {
                retorno = "Obesidade III";
            }

            return retorno ;
            
        }

        //Mensagem

        public void mensagem()
        {
            //Obter cálculo
            double obterCalc = imc();

            //Obter resultado do IMC 
            string obterIMC = resulImc(obterCalc);

            //Exibir Mensagem
            
            Console.WriteLine("Seu IMC é de "+ Math.Round(obterCalc, 2) + ", e a situação do seu IMC é de: " + obterIMC);
        }
    }
}
