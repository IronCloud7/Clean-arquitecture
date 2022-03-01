using Assets.Scripts.Estructura._1_Aplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class MenuController// : IDisposable
    {
    //    private InputModel _inputModel;
    //    private Attacker _attackUseCase;
    //    private HealthRefresher _healthRefreshUseCase;

    //    public MenuController(InputModel inputModel, Attacker attackUseCase, HealthRefresher healthRefreshUseCase)
    //    {
    //        _inputModel = inputModel;
    //        _attackUseCase = attackUseCase;
    //        _healthRefreshUseCase = healthRefreshUseCase;

    //        _inputModel.ButtonA.Subscribe(BotonAUpdated);
    //        _inputModel.ButtonB.Subscribe(BotonBUpdated);
    //        _inputModel.ButtonY.Subscribe(BotonYUpdated);
    //        _inputModel.BotonZ.Subscribe(BotonZUpdated);
    //    }

    //    public void BotonAUpdated()
    //    {
    //        _attackUseCase.Attack(new WeaponInputData("1"));
    //    }

    //    public void BotonBUpdated()
    //    {
    //        _attackUseCase.Attack(new WeaponInputData("2"));
    //    }

    //    public void BotonYUpdated()
    //    {
    //        _attackUseCase.Attack(new WeaponInputData("3"));
    //    }

    //    public void BotonZUpdated()
    //    {
    //        _healthRefreshUseCase.Refresh(new HealthInputData("1"));
    //    }

    //    public void Dispose()
    //    {
    //        _inputModel.ButtonA.Unsubscribe(BotonAUpdated);
    //        _inputModel.ButtonB.Unsubscribe(BotonBUpdated);
    //        _inputModel.ButtonY.Unsubscribe(BotonYUpdated);
    //        _inputModel.ButtonY.Unsubscribe(BotonZUpdated);
    //    }
    }
}
