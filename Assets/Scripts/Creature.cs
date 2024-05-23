using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Creature : MonoBehaviour, IEatable, IPointerEnterHandler, IPointerUpHandler {
    [SerializeField]
    private Shake _shaker;
    
    private IAttribute[] _attributes;

    public event Action<int> OnHealthChanged = (health) => {};
    
    private int Health { get; set; }
    public string Name { get; private set; }
    
    private void Start() {
        Health = 10;
        OnHealthChanged.Invoke(Health);
    }

    private void Eat(IEatable eatable) {
        Health += eatable.GetNutrition();
        OnHealthChanged.Invoke(Health);
        print($"Health: {Health}");
    }
    
    public int GetNutrition() {
        gameObject.SetActive(false);
        return Health;
    }
    
    public void OnPointerEnter(PointerEventData eventData) {
        var drag = eventData.pointerDrag;
        if (drag == null)
            return;
        _shaker.ShakeVisuals();
    }
    
    public void OnPointerUp(PointerEventData eventData) {
        var card = eventData.pointerEnter;
        
        if (card is null)
            return;
        
        if (card.TryGetComponent(out IEatable food)) {
            Eat(food);
        }
    }
}