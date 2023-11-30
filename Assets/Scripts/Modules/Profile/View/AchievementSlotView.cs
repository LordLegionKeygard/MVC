using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Data;

public class AchievementSlotView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_nameText;
    [SerializeField] private TextMeshProUGUI m_completedOnText;
    [SerializeField] private Image m_icon;

    public void SetAchievementData(AchievementData achievementData)
    {
        m_nameText.text = achievementData.Name;
        m_completedOnText.text = $"COMPLETED ON: {achievementData.CompletedOn.ToString("dd/MM/yyyy")}";
        m_icon.sprite = Resources.Load<Sprite>($"Icons/Achievements/{achievementData.Icon}");
    }
}
