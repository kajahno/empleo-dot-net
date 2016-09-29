﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EmpleoDotNet.Core.Domain;

namespace EmpleoDotNet.Data.TableConfigurations
{
    /// <summary>
    /// Base Table Configuration para pre-configurar todas las tablas y sobreescribir el nombre del Campo Id
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class TableConfiguration<T> : 
        EntityTypeConfiguration<T> where T : EntityBase
    {
        protected TableConfiguration()
        {
            /*Segun el diseño inicial, se deseaba que los PK todos se llamaran Id,
            Para mantener esta comodidad pero generar una DB apta para el mundo real 
            Cambiar Nombre de la columna.*/
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName($"{typeof (T).Name}Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}