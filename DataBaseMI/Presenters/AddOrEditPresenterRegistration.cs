using CommonClassLibrary;
using ConteinerLibrary;

namespace Presenters
{
    /// <summary>
    /// Регистрация presenter в контейнере
    /// </summary>
    public class AddOrEditPresenterRegistration
    {
        public static void RegistrationInContainer(Conteiner conteiner)
        {
            Conteiner.GetInstance().ClassRegister<User, UserAddOrEditPresenter>();//регистрируем свой Presenter (UserAddOrEditPresenter) для кдасса User
            Conteiner.GetInstance().ClassRegister<Calibrator, CalibratorAddOrEditPresenter>();//регистрируем свой Presenter (CalibratorAddOrEditPresenter) для кдасса Calibrator
        }
    }
}
