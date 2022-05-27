using Microsoft.EntityFrameworkCore;

namespace CommonClassLibrary
{
    /// <summary>
    /// Поверитель
    /// </summary>
    [Index(nameof(Surname), nameof(Name), IsUnique = true, Name = "Фамилия и имя поверителя")] //Фимилия + Имя д.б. уникальными
    public class Calibrator : BaseUser, ICloneable
    {

    }
}
