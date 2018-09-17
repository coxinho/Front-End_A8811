using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Front_End_A8811.Models
{
    public class Fisabrantes : DbContext
    {

        public Fisabrantes() : base("Fisabrantes") { }

            // 'tabelas' a serem criadas na Base de Dados
            public virtual DbSet<Funcionarios> Funcionario { get; set; }
            public virtual DbSet<Utentes> Utente { get; set; }
            public virtual DbSet<Consultas> Consulta { get; set; }
            public virtual DbSet<Prescricao> Prescricao { get; set; }


            protected override void OnModelCreating()
        {
                modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();  // força a que a chave forasteira não tenha a propriedade 'on delete cascade'
                modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();  // força a que a chave forasteira não tenha a propriedade 'on delete cascade'

                base.OnModelCreating(modelBuilder);
            }
        }

}