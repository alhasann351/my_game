using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelCollider frontRightWheelCollider, frontLeftWheelCollider, backRightWheelCollider, backLeftWheelCollider;
    public Transform frontRightWheelTransform, frontLeftWheelTransform, backRightWheelTransform, backLeftWheelTransform;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        MotorForce();
        UpdateWheels();
    }

    void MotorForce()
    {
        frontRightWheelCollider.motorTorque = 10f;
        frontLeftWheelCollider.motorTorque = 10f;
    }

    void UpdateWheels()
    {
        RotateWheel(frontRightWheelCollider, frontRightWheelTransform);
        RotateWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        RotateWheel(backRightWheelCollider, backRightWheelTransform);
        RotateWheel(backLeftWheelCollider, backLeftWheelTransform);
    }

    void RotateWheel(WheelCollider wheelCollider, Transform transform)
    {
        Vector3 position;
        Quaternion rotation;

        wheelCollider.GetWorldPose(out position, out rotation);

        transform.position = position;
        transform.rotation = rotation;
    }
}
