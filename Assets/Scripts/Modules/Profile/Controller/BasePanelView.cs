using TMPro;
using UnityEngine;

public class BasePanelView : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject SelectImage;
    public TextMeshProUGUI ButtonTexts;
    public TextMeshProUGUI PanelText;
    public Color ActiveColor;
    public Color UnactiveColor;
    public string PanelName;

    public virtual void PanelToggle(bool state)
    {
        MainPanel.SetActive(state);
        SelectImage.SetActive(state);
        ButtonTexts.color = state ? ActiveColor : UnactiveColor;

        if(state) PanelText.text = PanelName;
    }
}
