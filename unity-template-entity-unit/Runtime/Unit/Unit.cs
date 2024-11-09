/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class Unit : MonoBehaviour, IComponent, ICreated<PrefData>
{
    public string physicsLayer;
    //public UnitData unitData;

    public void OnCreated(PrefData pd)
    {
        //Debug.Log("Creating Unit");

        //World.INSTANCE.units.Add(uc.ud);

        var lm = LayerMask.NameToLayer(physicsLayer);
        gameObject.layer = lm;
    }
}
