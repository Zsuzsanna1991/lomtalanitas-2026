using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Lomtalanitas.Models
{
    [Table("körzetek")]
    public class Korzet
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("körzet_szám")]
        public string KorzetSzam { get; set; }

        [Column("lomtalanítás_dátum")]
        public DateTime LomtalanitasDatum { get; set; }

        public ICollection<Utcanev>? Utcanevek { get; set; } // navigációs property
    }
}