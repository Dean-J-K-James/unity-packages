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
    public void Create(string k, float x, float y)
    {
        var i = Instantiate(Asset.INSTANCE.Get<Unit>(k));
        //var u = new UnitData(i);

        //i.unitData = u;
        i.transform.SetParent(transform);
        i.transform.position = new Vector2(x, y);
        i.gameObject.SetActive(true);

        i.InvokeCreated();
        i.InvokeChanged();

        //return u;
    }
}
