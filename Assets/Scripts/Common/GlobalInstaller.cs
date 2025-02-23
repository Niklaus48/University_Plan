using Common.Interfaces;
using UnityEngine;
using Zenject;

namespace Common
{
    [CreateAssetMenu(menuName = "DI/GlobalInstaller", fileName = "GlobalInstaller")]
    public class GlobalInstaller : ScriptableObjectInstaller<GlobalInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<INetworkManager>().To<NetworkManager>().AsSingle().NonLazy();
        }
    }
}