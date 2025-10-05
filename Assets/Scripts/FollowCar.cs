using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public Transform carTransform, cameraPointTransform;

    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.LookAt(carTransform);
        transform.position = Vector3.SmoothDamp(transform.position, cameraPointTransform.position, ref velocity, 5f * Time.deltaTime);
    }
}
