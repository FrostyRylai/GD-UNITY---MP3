using UnityEngine;
using UnityEngine.InputSystem;

public class GunShoot : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    Transform bulletLocation;

    int bulletCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletCounter = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Mouse.current.leftButton.wasPressedThisFrame && bulletCounter > 0))
        {
            Instantiate(bulletPrefab, bulletLocation.position, bulletLocation.rotation);
            bulletCounter--;
        }
        else
        {
            if (Keyboard.current.rKey.wasPressedThisFrame)
            {
                bulletCounter += 3;
            }
        }
      
    }
}
