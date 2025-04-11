using Main_Menu.Model;
using Main_Menu.Model.Interfaces;
using Zenject;

namespace Main_Menu
{
    public class MainSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IPlanManager>().To<PlanManager>().AsSingle().NonLazy();
        }
    }
}