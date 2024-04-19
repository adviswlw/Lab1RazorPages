using System.ComponentModel.DataAnnotations;

namespace Lab1.Data
{
    /// <summary>
    /// Простой POCO класс представляющий строку данных
    /// </summary>
    // TODO: переименуйте этот файл и класс, добавьте атрибуты

    /// <summary>
    /// класс, представляющий язык программирования
    /// </summary>
    public class ProgrammingLanguage
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// название языка программирования
        /// </summary>
        [Required(ErrorMessage = "Поле 'Название' обязательно для заполнения.")]
        public string Name { get; set; }

        /// <summary>
        /// тип языка программирования 
        /// (функциональный, императивный, логический, другой)
        /// </summary>
        [Required(ErrorMessage = "Поле 'Тип' обязательно для заполнения.")]
        public string Type { get; set; }

        /// <summary>
        /// рейтинг языка программирования
        /// </summary>
        [Required(ErrorMessage = "Поле 'Рейтинг' обязательно для заполнения.")]
        [Range(1, 5, ErrorMessage = "Рейтинг должен быть в диапазоне 1 и 5.")]
        public int Rating { get; set; }
    }
}
