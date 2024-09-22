using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeManager : MonoBehaviour
{
    public static Type GetType(string type)
    {
		var ads = AppDomain.CurrentDomain.GetAssemblies();

		foreach (var item in ads)
		{
			Type t = Type.GetType(type + ", " + item.FullName);

			if (t != null)
			{
				return t;
			}
		}

		return null;
	}
}
