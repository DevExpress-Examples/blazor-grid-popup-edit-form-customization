using System.ComponentModel.DataAnnotations;

namespace BlazorGridPopupEditFormCustomization.Services {
    public class WeatherForecast {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Range(0, 100)]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        [Required]
        [MaxLength(50)]
        public string? Summary { get; set; }
    }
}