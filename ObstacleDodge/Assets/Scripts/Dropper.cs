using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float dropWaitTimer;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }


    void Update()
    {
        Debug.Log($"Elapsed Time: {Time.time}");
        if (Time.time >= dropWaitTimer)
        {
            DropObject();
        }
    }

    void DropObject()
    {
        rb.useGravity = true;
    }
}
