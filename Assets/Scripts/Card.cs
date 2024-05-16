using UnityEngine;

[RequireComponent(typeof(Drag))]
public class Card : MonoBehaviour {
    [SerializeField]
    private AudioSource _cardAudio;
    [SerializeField]
    private AudioClip _pickSound;
    [SerializeField]
    private AudioClip _dropSound;
    
    private Drag _drag;

    private void Awake() {
        _drag = GetComponent<Drag>();
    }

    private void Start() {
        _drag.OnPointerDown += PlayPickCardSound;
        _drag.OnPointerUp += PlayDropCardSound;
    }

    private void PlayPickCardSound() {
        _cardAudio.PlayOneShot(_pickSound);
    }
    
    private void PlayDropCardSound() {
        _cardAudio.PlayOneShot(_dropSound);
    }
}
