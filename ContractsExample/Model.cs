namespace ContractsExample;

/// <summary>
/// Модель для задачи параллельного программирования
/// </summary>
public class Model
{
    /// <summary>
    /// Данные 
    /// </summary>
    public string Data { get; set; }
    /// <summary>
    /// Номер модели
    /// </summary>
    public int Number { get; set; }
    /// <summary>
    /// Успешность обработки
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// Дата обработки
    /// </summary>
    public DateTime DateOfProcess { get; set; }
}