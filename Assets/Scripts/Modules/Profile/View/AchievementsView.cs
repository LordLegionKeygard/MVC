using UnityEngine;
using Data;

namespace Modules.Profile.View
{
    public class AchievementsView : MonoBehaviour
    {
        [SerializeField] private AchievementsBlockView m_achievementsBlockViewPrefab;
        [SerializeField] private Transform m_achievementsParent;
        private int m_achievementBlocks;

        public void SetAchievements(AchievementData[] achievementsData)
        {
            m_achievementBlocks = achievementsData.Length / 3 + 1;

            for (int i = 0; i < m_achievementBlocks; i++)
            {
                var achievementBlockView = Instantiate(m_achievementsBlockViewPrefab, m_achievementsParent);
                for (int k = i * 3; k < achievementsData.Length; k++)
                {
                    achievementBlockView.SetAchievementData(achievementsData[k]);                
                }
            }
        }
    }
}
