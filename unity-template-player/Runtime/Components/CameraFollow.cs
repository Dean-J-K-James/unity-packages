/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class CameraFollow : MonoBehaviour, IComponent, IUpdated<UnitData>
{
    /**
     * 
     */
    public void OnUpdated(UnitData ud)
    {
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
    }
}
