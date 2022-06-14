using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace todolistgql {

    [Index(nameof(Id), IsUnique = true)]
    public class ItemData
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title field is required.")]
        [StringLength(maximumLength:128)]
        public string Title { get; set; }
        [StringLength(maximumLength: 255)]
        public string Description { get; set; }
        public bool Done { get; set; }
        public int ListId {get; set;}
        public virtual ItemList ItemList { get; set; }
    }
}