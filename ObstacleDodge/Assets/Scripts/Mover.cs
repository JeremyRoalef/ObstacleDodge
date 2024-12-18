using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Movement Attributes")]

    [SerializeField]
    [Min(0)]
    float xVelocity = 1f;

    [SerializeField]
    [Min(0)]
    float zVelocity = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        //Time.DeltaTime changes the value based on the change in time from one frame to another.
        //Variable time changes.
        float xValue = Input.GetAxis("Horizontal") * xVelocity * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * zVelocity * Time.deltaTime;

        transform.Translate(xValue, 0, zValue);
    }
}
