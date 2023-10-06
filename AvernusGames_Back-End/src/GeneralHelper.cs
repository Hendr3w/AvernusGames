using System.Linq;
using System;
using Avernus_Games_Store.src.Models;

namespace Avernus_Games_Store.src
{
    //Métodos criados pelo ChatGPT
    public static class GeneralHelper
    {
        public static bool ValidarCPF(string cpf)
        {
            // Remova os caracteres não numéricos do CPF
            string cpfLimpo = cpf.Replace(".", "").Replace("-", "");

            // Verifique se o CPF tem 11 dígitos
            if (cpfLimpo.Length != 11)
                return false;

            // Verifique se todos os dígitos são iguais (CPF inválido)
            if (cpfLimpo.Distinct().Count() == 1)
                return false;

            // Calcula o primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpfLimpo[i].ToString()) * (10 - i);
            int resto = soma % 11;
            int digitoVerificador1 = (resto < 2) ? 0 : 11 - resto;

            // Calcula o segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpfLimpo[i].ToString()) * (11 - i);
            resto = soma % 11;
            int digitoVerificador2 = (resto < 2) ? 0 : 11 - resto;

            // Verifique se os dígitos verificadores estão corretos
            if (int.Parse(cpfLimpo[9].ToString()) != digitoVerificador1 || int.Parse(cpfLimpo[10].ToString()) != digitoVerificador2)
                return false;

            return true;
        }

        public static bool ValidarCNPJ(string cnpj)
        {
            // Remova os caracteres não numéricos do CNPJ
            string cnpjLimpo = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            // Verifique se o CNPJ tem 14 dígitos
            if (cnpjLimpo.Length != 14)
                return false;

            // Calcula o primeiro dígito verificador
            int[] pesosPrimeiroDigito = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpjLimpo[i].ToString()) * pesosPrimeiroDigito[i];
            int resto = soma % 11;
            int digitoVerificador1 = (resto < 2) ? 0 : 11 - resto;

            // Calcula o segundo dígito verificador
            int[] pesosSegundoDigito = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpjLimpo[i].ToString()) * pesosSegundoDigito[i];
            resto = soma % 11;
            int digitoVerificador2 = (resto < 2) ? 0 : 11 - resto;

            // Verifique se os dígitos verificadores estão corretos
            if (int.Parse(cnpjLimpo[12].ToString()) != digitoVerificador1 || int.Parse(cnpjLimpo[13].ToString()) != digitoVerificador2)
                return false;

            return true;
        }
        public static bool ValidarSenha(string senhaD, string senhaC)
        {
            if(senhaC == senhaD)
                return true;
            else
                return false;
        }
        public static float CalcTotalProduto(ItemVenda item)
        {
            return item.Produto.CalcValorVenda(item.Produto.ValorCompra, item.Produto.Markup) * item.Qtd;

        }

        public static float CalcTotalVenda(Venda venda){
            List<ItemVenda> itens = venda.Itens;
            float som = 0;
            foreach(ItemVenda x in itens){
                som = som + (x.Produto.CalcValorVenda(x.Produto.ValorCompra, x.Produto.Markup) * x.Qtd);
            }
            return som;
        }

    }
}
   
