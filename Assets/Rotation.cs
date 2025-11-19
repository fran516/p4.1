using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float turretSpeed = 50.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = 0.0f;
        if (Input.GetKey (KeyCode.Q)) 
        {
            rotation = -turretSpeed * Time.deltaTime;
        } 
        else if (Input.GetKey (KeyCode.E)) 
        {
            rotation = turretSpeed * Time.deltaTime:
        }
        
        Transform t = gameObject.transform;
        t.Rotate (0.0f, rotation, 0.0f);
    }
}
