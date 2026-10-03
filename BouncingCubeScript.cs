using UnityEngine;

public class BouncingCubeScript : MonoBehaviour
{
    MeshRenderer bcRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bcRenderer = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Enter");
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        GameObject stage = collision.collider.gameObject;
        if (stage.name == "Stage")
        {
            MeshRenderer stageRender = stage.GetComponent<MeshRenderer>();
            stageRender.material.color = new Color(Random.Range(0, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            bcRenderer.material.color = new Color(Random.Range(0, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }*/

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entry");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }
}
