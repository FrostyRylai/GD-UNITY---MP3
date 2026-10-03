using UnityEngine;

public class BulletForce : MonoBehaviour
{
    Rigidbody bulletRigid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletRigid = GetComponent<Rigidbody>();
        //bulletRigid.AddForce(Vector3.forward * 2000);
        bulletRigid.AddRelativeForce(Vector3.forward * 2000);
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.collider.name != "Stage")
        {
            GameObject obs = collision.collider.gameObject;
            Destroy(obs);
        }
        */
        Destroy(gameObject);
    }
}
