using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float dropWaitTimer;

    Rigidbody rb;
    MeshRenderer meshRenderer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }


    void Update()
    {
        //Debug.Log($"Elapsed Time: {Time.time}");
        if (Time.time >= dropWaitTimer)
        {
            DropObject();
        }
    }

    void DropObject()
    {
        rb.useGravity = true;
        meshRenderer.enabled = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

        }
    }
}
