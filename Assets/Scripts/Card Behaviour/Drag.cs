using System;
using DG.Tweening;
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
        transform.DOScale(Vector3.one * 1.2f, .3f).SetEase(Ease.InOutBack);
        OnPointerDown.Invoke();
    }
    
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {
        _graphic.raycastTarget = true;
        transform.DOScale(Vector3.one, .3f).SetEase(Ease.InOutBack);
        OnPointerUp.Invoke();
    }
}
