
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public GameObject FlipperObject;
    public string InputButton;
    public float Torque;

    private HingeJoint _hingeJoint;

    private void Start()
    {
        _hingeJoint = FlipperObject.GetComponent<HingeJoint>();
    }

    private void FixedUpdate()
    {
        _hingeJoint.useMotor = Input.GetButton(InputButton);
    }
}
