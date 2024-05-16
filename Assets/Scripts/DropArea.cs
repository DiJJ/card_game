using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) {
        eventData.pointerDrag.transform.SetParent(transform);
    }
}
