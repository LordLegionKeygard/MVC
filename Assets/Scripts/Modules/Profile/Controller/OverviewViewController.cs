using System;
using System.Linq;
using Data.Matching;
using Modules.Profile.Model;
using Modules.Profile.View;
using Zenject;

namespace Modules.Profile.Controller
{
    public class OverviewViewController : IInitializable, IDisposable
    {
        private readonly ProfileModel m_model;
        private readonly OverviewView m_view;

        public OverviewViewController(ProfileModel model, OverviewView view)
        {
            m_model = model;
            m_view = view;
        }

        public void Initialize()
        {
            var accountData = m_model.GetAccount();
            m_view.Enabled += FirstSpawn;
            m_view.MatchDataSelected += SpawnParameters;
            m_view.SetMatches(accountData.Matches);
            FirstSpawn();
        }

        private void FirstSpawn()
        {
            var accountData = m_model.GetAccount();
            var matchData = accountData.Matches.First();
            SpawnParameters(matchData);
        }

        private void SpawnParameters(MatchData matchData)
        {
            m_view.ClearMatchParameters();
            for (int i = 0; i < matchData.Parameters.Length; i++)
            {
                m_view.ViewParameter(matchData.Parameters[i]);
            }
        }

        public void Dispose()
        {
            m_view.MatchDataSelected -= SpawnParameters;
            m_view.Enabled -= FirstSpawn;
        }
    }
}
