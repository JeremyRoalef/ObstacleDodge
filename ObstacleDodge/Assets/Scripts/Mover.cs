using UnityEngine;

public class Mover : MonoBehaviour
{
    //[Header("Movement Attributes")]


    void Start()
    {
        
    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        transform.Translate(xValue, 0, zValue);
    }
}
