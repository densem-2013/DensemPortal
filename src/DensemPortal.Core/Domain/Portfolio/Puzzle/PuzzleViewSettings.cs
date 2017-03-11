using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DensemPortal.Core.Domain.Main;

namespace DensemPortal.Core.Domain.Portfolio.Puzzle
{
    public class PuzzleViewSettings : BaseEntity
    {
        public string UserId { get; set; }
        public int Demension { get; set; }
        public string PicturePath { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}
