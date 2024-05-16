using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler {
    [SerializeField]
    private Graphic _graphic;

    public event Action OnPointerDown = () => { };
    public event Action OnPointerUp = () => { };
    
    void IDragHandler.OnDrag(PointerEventData eventData) {
        transform.position = eventData.pointerCurrentRaycast.worldPosition;
    }
    
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData) {
        _graphic.raycastTarget = false;
        transform.localScale = Vector3.one * 1.1f;
        OnPointerDown.Invoke();
    }
    
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {
        _graphic.raycastTarget = true;
        transform.localScale = Vector3.one;
        OnPointerUp.Invoke();
    }
}
