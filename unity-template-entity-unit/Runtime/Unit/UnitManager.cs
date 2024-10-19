/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */
public class UnitManager : Singleton<UnitManager>
{
    public UnitData Create(string k, int x, int y)
    {
        var i = Instantiate(Asset.INSTANCE.Get<Unit>(k));
        var u = new UnitData(i);

        i.unitData = u;
        i.transform.SetParent(transform);
        i.transform.position = new Vector2(x, y);
        i.gameObject.SetActive(true);

        i.InvokeCreated(u);

        return u;
    }
}
