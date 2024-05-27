using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShakeOnHover : MonoBehaviour, IPointerEnterHandler {
    private void ShakeVisuals() {
        transform.DOShakeRotation(0.2f, 20f);
        transform.DOShakePosition(0.2f, 20f);
    }
    
    public void OnPointerEnter(PointerEventData eventData) {
        var drag = eventData.pointerDrag;
        if (drag == null || drag == gameObject)
            return;
        ShakeVisuals();
    }
}
