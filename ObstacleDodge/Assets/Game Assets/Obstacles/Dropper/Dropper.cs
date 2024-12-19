using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float dropWaitTimer;

    Rigidbody rb;
    MeshRenderer meshRenderer;

    private void Awake()
    {
        //Initialize references
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }


    void Update()
    {
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
}
