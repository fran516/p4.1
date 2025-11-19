using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Transform t = gameObject.transform;
        t.localPosition = new Vector3(0.0f, 400.0f, -20.0f);
        t.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        
    }
}
