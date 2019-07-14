using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnotations.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage ="Nome deve ser preenchido")]
        public  string Nome { get; set; }
        [StringLength(50,MinimumLength = 5,ErrorMessage ="A Observação deve ter de 5 a 50 caracteres")]
        [Required(ErrorMessage ="Obrigatório a informação da Idade")]
        public string Observacao{ get; set; }
        [Range(18,50,ErrorMessage ="Minimo de 18 e maximo de 50 anos")]
        public int Idade { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*", ErrorMessage ="E-Mail com formato invalido")]
        public string Email{ get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}",ErrorMessage ="Login deve possuir letraz e 5 a 15 caracteres")]
        [Required(ErrorMessage = "Deve ser preenchido")]
        [Remote("LoginUnico","Pessoa",ErrorMessage ="Este Nome de Login Já existe")]
        public string Login { get; set; }
        [Required(ErrorMessage ="A Senha deve ser informada")]
        public string  Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage ="As Senhas não conferem")]
        public string ConfirmarSenha { get; set; }
    }
}