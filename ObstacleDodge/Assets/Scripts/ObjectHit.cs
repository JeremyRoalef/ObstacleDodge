using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField]
    Color hitColor = Color.red;

    MeshRenderer objRenderer;

    private void Awake()
    {
        objRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log($"{gameObject.name} hit");
        objRenderer.material.color = hitColor;
    }
}
