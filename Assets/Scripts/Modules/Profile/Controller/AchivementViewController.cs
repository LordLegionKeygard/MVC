using System;
using Modules.Profile.Model;
using Modules.Profile.View;
using Zenject;

namespace Modules.Profile.Controller
{
    public class AchivementViewController : IInitializable, IDisposable
    {

        private readonly ProfileModel m_model;
        private readonly AchievementsView m_view;

        public AchivementViewController(ProfileModel model, AchievementsView view)
        {
            m_model = model;
            m_view = view;
        }


        public void Initialize()
        {
            var accountData = m_model.GetAccount();
            m_view.SetAchievements(accountData.Achievements);
        }

        public void Dispose()
        {
            
        }
    }
}
