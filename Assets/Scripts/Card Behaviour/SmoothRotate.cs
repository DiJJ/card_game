using UnityEngine;

public class SmoothRotate : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField, Range(0.01f, 100f)]
    private float _rotationSpeed;
    [SerializeField]
    private bool _hardLock;
    
    private Vector3 _rotationDelta;
    private Vector3 _movementDelta;

    private void Update() {
        if (_hardLock)
            Lock();
        else
            SmoothRotation();
    }

    private void SmoothRotation() {
        Vector3 movement = (transform.position - _target.position);
        _movementDelta = Vector3.Lerp(_movementDelta, movement * 100f, 25 * Time.deltaTime);
        _rotationDelta = Vector3.Lerp(_rotationDelta, _movementDelta, _rotationSpeed * Time.deltaTime);
        transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp(_rotationDelta.x, -60, 60));
    }

    private void Lock() {
        transform.rotation = _target.rotation;
    }
}
