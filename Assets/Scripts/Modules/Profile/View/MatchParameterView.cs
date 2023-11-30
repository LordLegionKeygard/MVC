using UnityEngine;
using TMPro;
using Data.Matching;

public class MatchParameterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_header;
    [SerializeField] private TextMeshProUGUI m_subHeader;
    [SerializeField] private TextMeshProUGUI m_score;

    public void SetParameter(MatchParameter matchParameter)
    {
        m_header.text = matchParameter.Header;
        m_subHeader.text = matchParameter.SubHeader;
        m_score.text = $"{matchParameter.Score} PT.";
    }
}
