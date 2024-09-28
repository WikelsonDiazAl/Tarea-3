using System.ComponentModel.DataAnnotations;

class Reporte{
    public string Id {get; set;} = string.Empty;

    public DateTime Fecha {get; set;} = DateTime.Now;

    [Required(ErrorMessage = "El campo descripción es requerido")]
    [MinLength(10, ErrorMessage ="La descripción debe tene al menos 10 caracteres")]
    public string Descripcion {get; set;} = "";

    public double CostoEstimado {get; set;} = 0;

    public int Muertos {get; set;} = 0;

    public int Heridos {get; set;} = 0;

    public int VehiculosInvolucrados {get; set;} = 0;
}