using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField]
    Color hitColor = Color.red;

    MeshRenderer objRenderer;
    public bool IsHit { get; private set; } = false;

    private void Awake()
    {
        objRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && !IsHit)
        {
            IsHit = true;
            Debug.Log($"{gameObject.name} hit");
            objRenderer.material.color = hitColor;
        }
    }
}
