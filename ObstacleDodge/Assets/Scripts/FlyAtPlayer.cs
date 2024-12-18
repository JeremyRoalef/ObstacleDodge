using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField]
    [Min(0)]
    float moveTowardsSpeed = 1f;

    bool moveToObject = false;
    Vector3 positionToMoveTo;

    private void Update()
    {
        if (!moveToObject) { return; }

        //Move towards the player's position at given speed.
        transform.position = Vector3.MoveTowards(
            transform.position,
            positionToMoveTo,
            moveTowardsSpeed * Time.deltaTime
            );

        if (transform.position == positionToMoveTo)
        {
            Destroy(gameObject);
        }
    }

    public void MoveTowardsObject(Vector3 positionToMoveTo)
    {
        moveToObject = true;
        this.positionToMoveTo = positionToMoveTo;
    }
}
