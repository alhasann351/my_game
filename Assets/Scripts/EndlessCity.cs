using UnityEngine;

public class EndlessCity : MonoBehaviour
{
    [SerializeField] Transform playerCarTransform, otherCityTransform;
    [SerializeField] float halfLength = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        if(playerCarTransform.position.z > transform.position.z + halfLength + 10f)
        {
            transform.position = new Vector3(0, 0, otherCityTransform.position.z + halfLength * 2);
        }
    }
}
