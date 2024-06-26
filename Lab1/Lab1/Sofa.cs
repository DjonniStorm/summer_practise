using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1;
/// <summary>
/// Класс "Диван"
/// </summary>
public class Sofa
{
    private int? _length;
    public int? Length
    {
        get => _length;
        set
        {
            if (value > 0)
                _length = value;
        }
    }
    /// <summary>
    /// Закрытое поле ширина
    /// </summary>
    private int? _width;
    /// <summary>
    /// Свойство для получения и установки значение ширины
    /// </summary>
    public int? Width
    {
        get => _width;
        set
        {
            if (value > 0)
                _width = value;
        }
    }
    /// <summary>
    /// Закрытое поле высота
    /// </summary>
    private int? _height;
    public int? Height
    {
        get => _height;
        set
        {
            if (value > 0)
                _height = value;
        }
    }
    /// <summary>
    /// Закрытое поле материал отделки (гугл переводчик так сказал)
    /// </summary>
    private string? _finishing;
    public string? Finishing
    {
        get => _finishing;
        set
        {
            if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
                _finishing = value;
        }
    }
    private string? _name;
    public string? Name
    {
        get => _name;
        set
        {
            if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
                _name = value;
        }
    }
    /// <summary>
    /// Подлокотники
    /// </summary>
    private bool _armrests;
    public bool Armrests
    {
        get => _armrests;
        set
        {
            _armrests = value;
        }
    }
    private bool _mechanism;
    public bool Mechanism
    {
        get => _mechanism;
        set
        {
            _mechanism = value;
        }
    }
}
