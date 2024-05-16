using UnityEngine;

public class SmoothFollow : MonoBehaviour {
    [SerializeField]
    private Transform _target;
    [SerializeField, Range(0.01f, 100f)]
    private float _followSpeed;

    private Vector3 _movementDelta;

    private void Update() {
         _movementDelta = Vector3.Lerp(_movementDelta, _target.position, _followSpeed * Time.deltaTime);
         transform.position = _movementDelta;
    }
}
