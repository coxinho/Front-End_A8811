﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Front-End_A8811.Models
{
    public class Utentes
    {
        //***********************************************************************
        // A classe Utentes e a classe Consultas têm um relacionamento
        // Muitos-para-Muitos em que só existem atributos nas classes Utentes
        // e Consultas.
        //
        // Nesta circunstância, a forma de exprimir o relacionamento
        // é criar uma 'lista' de objetos de uma das classes na outra classe,
        // e vice-versa.
        // Aqui, NÃO é necessário criar uma classe para exprimir o relacionamento.
        //***********************************************************************
        public Utentes()
        {
            ListaDeConsultasAoUtente = new HashSet<Consultas>
    ();
    }

    [Key]
    public int idUtente { get; set; }

    [Display(Name ="Nome do Utente")]
    public string Nome { get; set; }

    [Display(Name ="Data de Nascimento")]
    public DateTime DataNasc { get; set; }

    [Display(Name ="NIF")]
    public string NIF { get; set; }

    [Display(Name ="Nº de Telefone")]
    public string Telefone { get; set; }

    [Display(Name ="Morada")]
    public string Morada { get; set; }

    [Display(Name ="Código Postal")]
    public string CodPostal { get; set; }

    [Display(Name ="Sistema Nacional Saúde")]
    public string SNS { get; set; }

    //**************************************************************************
    // Lista das Consultas associadas ao Utente
    public virtual ICollection<Consultas>
        ListaDeConsultasAoUtente { get; set; }

        }
}
