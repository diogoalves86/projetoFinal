using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineDiary.Classes
{
    public static class Valida_Dados
    {
        public static string Valida_Campo(object instancia, object atributo_instancia, string[] atributos)
        {
            try
            {
                foreach (var atributo in atributos)
                {
                    var propriedades = typeof(Disciplina).GetProperty(atributo)
                    .GetCustomAttributes(false)
                    .OfType<ValidationAttribute>()
                    .ToArray();
                    ValidationContext valida = new ValidationContext(instancia);
                    Validator.ValidateValue(atributo_instancia, valida, propriedades);
                    //atributo.GetCustomAttributes(false)
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}