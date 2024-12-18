using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Movement Attributes")]

    [SerializeField]
    float xValue = 0f;

    [SerializeField]
    float yValue = 0f;

    [SerializeField]
    float zValue = 0f;


    void Start()
    {
        
    }

    void Update()
    {


        transform.Translate(xValue,yValue,zValue);
    }
}
