/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System;

/**
 * 
 */
public static class TypeFromString
{
	/**
	 * 
	 */
	public static Type Get(string type)
	{
        foreach (var item in AppDomain.CurrentDomain.GetAssemblies())
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
