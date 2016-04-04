using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restorator.Model
{
    [Table("Tables")]
    public class Table
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TableId { get; set; }

        [Required]
        public Guid HallId { get; set; }

        [Required]
        public ushort? NumberOfPlaces { get; set; }

        public bool CheckForVip { get; set; }

        [ForeignKey("HallId")]
        public Hall Hall { get; set; }

        public Table()
        {
        }

        public Table(Guid hallId, ushort? numberOfPlaces, bool checkForVip)
        {
            HallId = hallId;
            NumberOfPlaces = numberOfPlaces;
            CheckForVip = checkForVip;
        }
    }
}
