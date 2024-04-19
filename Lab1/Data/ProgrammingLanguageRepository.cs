using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Lab1.Data;

/// <summary>
/// Класс репозиторий для сохранения данных о языках программирования
/// </summary>
// TODO: не забудьте переименовать класс +
// TODO: реализуйте здесь чтение и запись файла +

public class ProgrammingLanguageRepository
{
    private readonly string _filePath = "data2.json";
    
    private IList<ProgrammingLanguage> _data;

    public ProgrammingLanguageRepository()
    {
        if (File.Exists(_filePath))
        {
            var lines = File.ReadAllLines(_filePath);
            _data = lines.Select(line =>
            {
                var parts = line.Split(',');
                return new ProgrammingLanguage
                {
                    Id = Guid.Parse(parts[0]),
                    Name = parts[1],
                    Type = parts[2],
                    Rating = int.Parse(parts[3])
                };
            }).ToList();
        }
        else
        {
            _data = new List<ProgrammingLanguage>();
        }
    }

    public ProgrammingLanguage Get(Guid id)
    {
        return _data.FirstOrDefault(d => d.Id == id);
    }

    /// <summary>
    /// Возврщает все элементы списка
    /// </summary>
    /// <returns>Список всех языков программироввания</returns>
    public IList<ProgrammingLanguage> List()
    {
        lock (this)
        {
            if (File.Exists(_filePath))
            {
                var lines = File.ReadAllLines(_filePath);
                _data = lines.Select(line =>
                {
                    var parts = line.Split(',');
                    return new ProgrammingLanguage
                    {
                        Id = Guid.Parse(parts[0]),
                        Name = parts[1],
                        Type = parts[2],
                        Rating = int.Parse(parts[3])
                    };
                }).ToList();
            }
            return _data;
        }
    }

    /// <summary>
    /// Добавляет новую запись
    /// </summary>
    /// <param name="data">Новая запись о нового языка программирования</param>
    public void Add(ProgrammingLanguage data)
    {
        lock (this)
        {
            data.Id = Guid.NewGuid();
            _data.Add(data);
            SaveData();
        }
    }

    /// <summary>
    /// Обновляет запись о языках программирования
    /// </summary>
    /// <param name="data">Запись о языке программирования</param>
    public void Update(ProgrammingLanguage data)
    {
        lock (this)
        {
            var index = _data.ToList().FindIndex(d => d.Id == data.Id);
            if (index != -1)
            {
                _data[index] = data;
                SaveData();
            }
        }
    }

    /// <summary>
    /// Удаляет запись о языках программирования по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор записи о языках программирования</param> 
    public void Remove(Guid id)
    {
        lock (this)
        {
            var data = _data.FirstOrDefault(d => d.Id == id);
            if (data != null)
            {
                _data.Remove(data);
                SaveData();
            }
        }
    }

    /// <summary>
    /// сохранить двнные в файл
    /// </summary>
    /// <param name="id">Идентификатор записи о языках программирования</param>
    private void SaveData()
    {
        var lines = _data.Select(d => $"{d.Id},{d.Name},{d.Type},{d.Rating}");
        File.WriteAllLines(_filePath, lines);

    }
}
