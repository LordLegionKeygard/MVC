using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Data.Matching;
using System;

public class MatchView : MonoBehaviour
{
    public event Action<MatchData> MatchDataSelected;
    [SerializeField] private Image m_icon;
    [SerializeField] private TextMeshProUGUI m_matchTypeText;
    [SerializeField] private Button m_button;
    private MatchData m_matchData;

    private void Awake()
    {
        m_button.onClick.AddListener(OnButtonClicked);
    }

    public void SetMatchData(MatchData matchData)
    {
        m_matchData = matchData;
        m_icon.sprite = Resources.Load<Sprite>($"Icons/MatchTypes/{matchData.Icon}");
        m_matchTypeText.text = matchData.MatchType.ToString();
    }

    private void OnButtonClicked()
    {
        MatchDataSelected?.Invoke(m_matchData);
    }

    private void OnDestroy()
    {
        m_button.onClick.RemoveListener(OnButtonClicked);
    }
}
