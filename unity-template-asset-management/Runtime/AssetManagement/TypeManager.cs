/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System;
using UnityEngine;

/**
 * 
 */
public class TypeManager : MonoBehaviour
{
    /**
	 * 
	 */
    public static Type GetType(string type) { foreach (var item in AppDomain.CurrentDomain.GetAssemblies()) { Type t = Type.GetType(type + ", " + item.FullName); if (t != null) { return t; } } return null; }
}
