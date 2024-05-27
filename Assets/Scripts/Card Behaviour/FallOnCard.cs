using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class FallOnCard : MonoBehaviour, IPointerUpHandler {
    public event Action<GameObject> OnCardDrop = (card) => { };
    
    public void OnPointerUp(PointerEventData eventData) {
        var card = eventData.pointerEnter;
        
        if (card is null)
            return;
        
        OnCardDrop.Invoke(card);
    }
}
