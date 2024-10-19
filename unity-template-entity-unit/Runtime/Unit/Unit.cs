/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class Unit : MonoBehaviour, IComponent, ICreated<PrefData>
{
    public int layerMask;
    public UnitData unitData;

    public void OnCreated(PrefData pd)
    {
        //Debug.Log("Creating Unit");

        //World.INSTANCE.units.Add(uc.ud);
        gameObject.layer = layerMask;
    }
}
