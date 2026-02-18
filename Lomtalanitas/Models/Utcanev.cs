using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lomtalanitas.Models
{
    [Table("utcanevek")]
    public class Utcanev
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("utca_név")]
        public string? UtcaNev { get; set; }

        [Column("körzet_id")]
        public int KorzetId { get; set; }

        [ForeignKey("KorzetId")]
        public Korzet? Korzet { get; set; }  // nullable a biztonságos joinhoz
    }
}