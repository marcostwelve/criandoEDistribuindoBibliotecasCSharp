﻿
namespace bytebank.Modelos.ADM.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        internal protected override double getBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
