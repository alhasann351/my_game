using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform playerCarTransform;
    [SerializeField] float offSet = -15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.z = playerCarTransform.position.z + offSet;
        transform.position = cameraPosition;
    }
}
