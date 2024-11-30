/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using UnityEngine;

/**
 * 
 */
public static class XUnitEventExtensions
{
    //
    public static void InvokeUnitDie(this MonoBehaviour go) { foreach (var item in go.GetComponents<IUnitDie>()) { item.OnUnitDie(); } }
}
