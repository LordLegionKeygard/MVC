using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Modules.Profile.View
{
	public class ProfileView : MonoBehaviour
	{
		[SerializeField] private Image m_avatar;
		[SerializeField] private TextMeshProUGUI m_playerNameText;
		[SerializeField] private TextMeshProUGUI m_expericenceText;
		[SerializeField] private TextMeshProUGUI m_levelText;
		[SerializeField] private Slider m_experienceSlider;

		public void SetName(string name)
		{
			m_playerNameText.text = name;
		}

		public void SetAvatar(string name)
		{
			m_avatar.sprite = Resources.Load<Sprite>($"Icons/Avatars/{name}");
		}

		public void SetExperience(int value, int max)
		{
			m_experienceSlider.maxValue = max;
			m_experienceSlider.value = value;
			m_expericenceText.text = $"{value}/{max}";
		}

		public void SetLevel(int value)
		{
			m_levelText.text = $"LEVEL {value}:";
		}
	}
}