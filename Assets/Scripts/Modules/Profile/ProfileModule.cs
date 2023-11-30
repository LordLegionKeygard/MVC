using Modules.Profile.Controller;
using Modules.Profile.Model;
using Modules.Profile.View;
using UnityEngine;
using Zenject;

namespace Modules.Profile
{
    public class ProfileModule : MonoInstaller
    {
        [SerializeField] private ProfileView m_profileView;
        [SerializeField] private OverviewView m_overviewView;
        [SerializeField] private AchievementsView m_achievementsView;
    
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ProfileModel>().AsSingle().NonLazy();

            Container.BindInterfacesAndSelfTo<ProfileController>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<OverviewViewController>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<AchivementViewController>().AsSingle().NonLazy();

            Container.BindInstance(m_profileView).AsSingle().NonLazy();
            Container.BindInstance(m_overviewView).AsSingle().NonLazy();
            Container.BindInstance(m_achievementsView).AsSingle().NonLazy();
        }
    }
}
