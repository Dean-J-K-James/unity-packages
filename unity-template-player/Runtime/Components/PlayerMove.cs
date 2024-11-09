/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using Codice.CM.Common;
using UnityEngine;

/**
 * 
 */
public class PlayerMove : MonoBehaviour, IComponent, IUpdated
{
    public float movementSpeed; //

    /**
     * 
     */
    public void OnUpdated()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.W)) { movement.y += 1; }
        if (Input.GetKey(KeyCode.A)) { movement.x -= 1; }
        if (Input.GetKey(KeyCode.S)) { movement.y -= 1; }
        if (Input.GetKey(KeyCode.D)) { movement.x += 1; }

        movement.Normalize();
        GetComponent<Rigidbody2D>().velocity = movement * movementSpeed;
    }
}
