using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // ?????�용?� 변경하지 �?�???
    
    private Transform camT;
    [SerializeField] private Vector3 CamOffset;
    void Start()
    {
        if (Camera.main != null) camT = Camera.main.transform;
    }

    void LateUpdate()
    {
        var position = transform.position;
        position.z = -10;
        camT.position = position + CamOffset;
    }
}
