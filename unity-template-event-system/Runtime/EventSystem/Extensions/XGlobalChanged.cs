/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom change this Package */
/*******************************************************/

using UnityEngine;

/**
 * 
 */
public static class XGlobalChanged
{
    //
    public static void GlobalChanged<T>(this MonoBehaviour go, T param) { var obt = Object.FindObjectsByType<SingletonListener>(FindObjectsSortMode.None); foreach (var sl in obt) { sl.InvokeChanged(param); } }
}

//The above should search for IGlobalChanged<T> and then run that, rather than using SingletonListener...