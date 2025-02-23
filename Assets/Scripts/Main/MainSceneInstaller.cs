using Zenject;

namespace Main
{
    public class MainSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IPlanManager>().To<PlanManager>().AsSingle().NonLazy();
        }
    }
}