using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Creature : MonoBehaviour, IEatable {
    [SerializeField] private HealthDisplay _healthDisplay;
    [SerializeField] private FallOnCard _fallOnCard;
    
    private List<IAttribute> _attributes;
    private int Health { get; set; }

    private void Start() {
        Health = 10;
        _healthDisplay.UpdateText(Health);
        _attributes = new();
    }

    private void TryEat(GameObject card) {
        if (card.TryGetComponent(out IEatable food) == false)
            return;
        
        if (_attributes.All(attribute => attribute.CanEat(food)))
            Eat(food);
    }

    private void Eat(IEatable food) {
        Health += food.GetNutrition();
        _healthDisplay.UpdateText(Health);
    }

    public int GetNutrition() {
        gameObject.SetActive(false);
        return Health / 2;
    }

    public void AddAttribute(IAttribute attribute) {
        _attributes.Add(attribute);
    }

    private void OnEnable() {
        _fallOnCard.OnCardDrop += TryEat;
    }

    private void OnDisable() {
        _fallOnCard.OnCardDrop -= TryEat;
    }
}