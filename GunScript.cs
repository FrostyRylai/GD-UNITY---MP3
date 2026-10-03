using UnityEngine;
using UnityEngine.InputSystem;

public class GunScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotY = Mouse.current.delta.ReadValue().x;
        transform.Rotate(0, rotY * .5f, 0);
    }
}
