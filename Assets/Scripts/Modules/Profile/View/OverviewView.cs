using UnityEngine;
using Data.Matching;
using System;
using System.Collections.Generic;

namespace Modules.Profile.View
{
    public class OverviewView : MonoBehaviour
    {
        public event Action Enabled;
        public event Action<MatchData> MatchDataSelected;
        [SerializeField] private MatchView m_matchViewPrefab;
        [SerializeField] private MatchParameterView m_matchParameterViewPrefab;
        [SerializeField] private Transform m_matchesParent;
        [SerializeField] private Transform m_matcheParametersParent;
        private List<MatchView> m_matchViews = new();
        private List<MatchParameterView> m_matchParametersViews = new();

        private void OnEnable()
        {
            Enabled?.Invoke();
        }

        public void SetMatches(MatchData[] matchDatas)
        {
            UnsubscribeMatchViews();
            ClearMatchViews();
            for (int i = 0; i < matchDatas.Length; i++)
            {
                var matchView = Instantiate(m_matchViewPrefab, m_matchesParent);
                matchView.SetMatchData(matchDatas[i]);
                matchView.MatchDataSelected += MatchDataSelected;
                m_matchViews.Add(matchView);
            }
        }

        public void ViewParameter(MatchParameter matchParameter)
        {
            var matchParameterView = Instantiate(m_matchParameterViewPrefab, m_matcheParametersParent);
            matchParameterView.SetParameter(matchParameter);
            m_matchParametersViews.Add(matchParameterView);
        }

        public void ClearMatchParameters()
        {
            for (int i = 0; i < m_matchParametersViews.Count; i++)
            {
                Destroy(m_matchParametersViews[i].gameObject);
            }
            m_matchParametersViews.Clear();
        }

        private void ClearMatchViews()
        {
            for (int i = 0; i < m_matchViews.Count; i++)
            {
                Destroy(m_matchViews[i].gameObject);
            }
            m_matchViews.Clear();
        }

        private void UnsubscribeMatchViews()
        {
            for (int i = 0; i < m_matchViews.Count; i++)
            {
                m_matchViews[i].MatchDataSelected -= MatchDataSelected;
            }
        }

        private void OnDestroy()
        {
            UnsubscribeMatchViews();
        }
    }
}
