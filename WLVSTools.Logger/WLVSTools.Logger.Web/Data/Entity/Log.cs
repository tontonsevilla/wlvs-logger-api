using System.ComponentModel.DataAnnotations;

namespace WLVSTools.Logger.Web.Data.Entity
{
    public class Log
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? ExceptionMessage { get; set; }

        [Required]
        public string? Exception { get; set; }

        [Required]
        public string? ExceptionType { get; set; }

        [Required]
        public string? ExceptionSource { get; set; }

        [Required]
        public string AppName { get; set; }

        [Required]
        public string? ExceptionUrl { get; set; }

        [Required]
        public DateTime? LogDate { get; set; } = DateTime.UtcNow;
    }
}
