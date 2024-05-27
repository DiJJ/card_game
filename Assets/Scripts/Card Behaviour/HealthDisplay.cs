using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour {
    [SerializeField]
    private TextMeshProUGUI _healthText;
    
    public void UpdateText(int health) {
        _healthText.text = $"{health}";
    }
}
