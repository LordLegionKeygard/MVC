using UnityEngine;
using Data;

public class AchievementsBlockView : MonoBehaviour
{
    [SerializeField] private AchievementSlotView[] m_achievementSlotView;
    [SerializeField] private int m_currentActiveSlots;

    public bool SetAchievementData(AchievementData achievementData)
    {
        for (int i = m_currentActiveSlots; i < m_achievementSlotView.Length; i++)
        {
            if (m_currentActiveSlots <= 3)
            {
                m_currentActiveSlots++;
                m_achievementSlotView[i].gameObject.SetActive(true);
                m_achievementSlotView[i].SetAchievementData(achievementData);
                return true;
            }
        }
        return false;
    }
}
