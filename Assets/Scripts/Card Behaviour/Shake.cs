using UnityEngine;
using DG.Tweening;

public class Shake : MonoBehaviour {
    public void ShakeVisuals() {
        transform.DOShakeRotation(0.2f, 20f);
        transform.DOShakePosition(0.2f, 20f);
    }
}
