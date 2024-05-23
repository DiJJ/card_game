using UnityEngine;
using UnityEngine.EventSystems;

public class CardAudio : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    [SerializeField]
    private AudioSource _source;
    [SerializeField]
    private AudioClip _pickSound;
    [SerializeField]
    private AudioClip _dropSound;

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData) {
        PlayPickCardSound();
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {
        PlayDropCardSound();
    }

    private void PlayPickCardSound() {
        _source.PlayOneShot(_pickSound);
    }
    
    private void PlayDropCardSound() {
        _source.PlayOneShot(_dropSound);
    }
}
