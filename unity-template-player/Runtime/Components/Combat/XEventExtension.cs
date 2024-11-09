/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using UnityEngine;

/**
 * 
 */
public static class XItemEventExtensions
{
    //
    public static void InvokeUseItem(this MonoBehaviour go, Unit s)         { foreach (var item in go.GetComponents<IUseItem>()) { item.OnUseItem(s);    } }
    public static void InvokeFireWpn(this MonoBehaviour go, Unit s, Unit t) { foreach (var item in go.GetComponents<IFireWpn>()) { item.OnFireWpn(s, t); } }
}
