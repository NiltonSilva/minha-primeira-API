using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O campo de 'Titulo' é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo de 'Diretor' é obrigatório.")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O campo de 'Gênero' não pode ser maior que 30 caracteres.")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração do filme deve ser entre 1 e 600 minutos.")]
        public int Duracao { get; set; }
    }
}
