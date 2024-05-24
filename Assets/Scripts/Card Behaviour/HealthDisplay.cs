using System;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour {
    [SerializeField]
    private TextMeshProUGUI _healthText;
    [SerializeField]
    private Creature _creature;
    
    private void UpdateText(int health) {
        _healthText.text = $"{health}";
    }

    private void OnEnable() {
        _creature.OnHealthChanged += UpdateText;
    }

    private void OnDisable() {
        _creature.OnHealthChanged -= UpdateText;
    }
}
