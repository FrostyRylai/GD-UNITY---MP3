using UnityEngine;

public class TargetScript : MonoBehaviour
{
    [SerializeField]
    GameObject explosionPrefab;
    [SerializeField]
    Transform explosionLocation;

    int ctr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ctr = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        MeshRenderer targetRender = GetComponent<MeshRenderer>();
        ctr++;
        if(ctr >= 3)
        {
            explosionLocation.position = targetRender.transform.position;
            explosionLocation.rotation = targetRender.transform.rotation;
            Instantiate(explosionPrefab, explosionLocation.position, explosionLocation.rotation);
            Destroy(gameObject);
        }
        targetRender.material.color = new Color(Random.Range(0, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
