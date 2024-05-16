using UnityEngine;
using UnityEngine.EventSystems;
using VContainer;

public class AlwaysOnTop : MonoBehaviour, IBeginDragHandler
{
    private IGameUI _gameUI;
    
    [Inject]
    private void Inject(IGameUI gameUI) {
        _gameUI = gameUI;
    }
    
    public void OnBeginDrag(PointerEventData eventData) {
        transform.SetParent(_gameUI.HandTransform);
    }
}
