using System;
using Modules.Profile.Model;
using Modules.Profile.View;
using Zenject;

namespace Modules.Profile.Controller
{
    public class ProfileController : IInitializable, IDisposable
    {
        private readonly ProfileModel m_model;
        private readonly ProfileView m_view;

        public ProfileController(ProfileModel model, ProfileView view)
        {
            m_model = model;
            m_view = view;
        }

        public void Initialize()
        {
            var accountData = m_model.GetAccount();
            m_view.SetName(accountData.Name);
            m_view.SetAvatar(accountData.AvatarIcon);
            m_view.SetExperience(accountData.Experience, accountData.ExperienceMax);
            m_view.SetLevel(accountData.Level);
        }

        public void Dispose()
        {

        }
    }
}
