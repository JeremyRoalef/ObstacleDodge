using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField]
    [Min(0)]
    float moveTowardsSpeed = 1f;

    Vector3 positionToMoveTo;

    bool moveToObject = false;

    private void Update()
    {
        if (!moveToObject) { return; }

        //Move towards the player's position at given speed.
        transform.position = Vector3.MoveTowards(
            transform.position,
            positionToMoveTo,
            moveTowardsSpeed * Time.deltaTime
            );

        //Destroy if it's reached it's desination
        if (transform.position == positionToMoveTo)
        {
            Destroy(gameObject);
        }
    }

    //Method to call in the collsion handler
    public void MoveTowardsObject(Vector3 positionToMoveTo)
    {
        moveToObject = true;
        this.positionToMoveTo = positionToMoveTo;
    }
}
