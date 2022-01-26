using UnityEngine;
using Zenject;

public class MainSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IMainManager>().To<MainManager>().FromComponentsInHierarchy().AsSingle();
        Container.Bind<IStatsCalculator>().To<StatsCalculator>().FromNew().AsSingle();
    }
}