
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public string InputButton;
    public float RotationSpeed;
    public float RotationLimit;

    private bool _triggered;
    private float _restingRotationY;
    private float _currentRotationY;

    public float CurrentRotation
    {
        get {
            return _currentRotationY - _restingRotationY;
        }
    }

    private void Start()
    {
        _restingRotationY = transform.localRotation.y;
        _currentRotationY = _restingRotationY;
    }

    private void Update()
    {
        _triggered = Input.GetButton(InputButton);
    }

    private void LateUpdate()
    {
        float targetRotation = _triggered ? RotationLimit : _restingRotationY;
        float rotationDelta = RotationSpeed * Time.deltaTime * (_triggered ? 1.0f : -1.0f);
        float rangeLeft = targetRotation - _currentRotationY;

        if (Mathf.Abs(rotationDelta) > Mathf.Abs(rangeLeft))
        {
            rotationDelta = rangeLeft;
        }

        _currentRotationY += rotationDelta;
        this.transform.Rotate(Vector3.up, rotationDelta);
    }
}
