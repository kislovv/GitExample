namespace ContractsExample;

/// <summary>
/// Интерфейс для взаимодействия с моделью ПП
/// </summary>
public interface IModelService
{
    /// <summary>
    /// Метод обработки моделей 
    /// </summary>
    /// <param name="models">Входящие модели</param>
    /// <returns>Строковое представление</returns>
    string ProcessModels(Model[] models);
}