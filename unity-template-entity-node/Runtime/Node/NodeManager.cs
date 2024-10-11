/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */
public class NodeManager : Singleton<NodeManager>
{
    //Dictionary<Vector2Int, T> entities = new Dictionary<Vector2Int, T>();
    Dictionary<Vector3Int, NodeData> entities = new Dictionary<Vector3Int, NodeData>();

	public NodeData Get(int x, int y, int l)
    {
        if (entities.ContainsKey(new Vector3Int(x, y, l)))
        {
            return entities[new Vector3Int(x, y, l)];
        }

        return null;
    }

    //public EntityData GetData(int x, int y)
    //{
    //    if (entityData.ContainsKey(new Vector2Int(x, y)))
    //    {
    //        return entityData[new Vector2Int(x, y)];
    //    }

    //    return null;
    //}

    public void Set(string e, int x, int y)
    {
        var a = Asset.INSTANCE.Get<Node>(e);

		//if (entities.ContainsKey(new Vector2Int(x, y)))
		//{
		Rem(x, y, a.layer);
        //}

        //var ed = NodeFactory.INSTANCE.Create(entity, x, y);

        //Debug.Log("Creating: " + ed.entity.name);

        //ed.entity = entity;
        //ed.tickCreated = TickManager.INSTANCE.tick;



        //entities[new Vector2Int(x, y)] = new NodeData<T>(Asset.INSTANCE.Get<T>(e));
        entities[new Vector3Int(x, y, a.layer)] = new NodeData(Asset.INSTANCE.Get<Node>(e), x, y);

        //entities[new Vector2Int(x, y)].entity.Invoke(new NodeCreated(entities[new Vector2Int(x, y)].id, x, y));
        entities[new Vector3Int(x, y, a.layer)].node.InvokeCreated(entities[new Vector3Int(x, y, a.layer)]);
        //entities[new Vector2Int(x, y)].entity.InvokeCreated(entities[new Vector2Int(x, y)]);

        //entities[new Vector2Int(x, y)].InvokeInstanceCreated(new Vector2Int(x, y));

        //NodeCreated nc;

        //nc.x = x;
        //nc.y = y;

        //entities[new Vector2Int(x, y)].entity.Invoke(nc);
        //entities[new Vector2Int(x, y)].entity.InvokeMessage("OnInstanceCreated", new Vector2Int(x, y));

        //entities[new Vector2Int(x, y)].gameObject.Invoke<IInstanceCreated, Vector2Int>(new Vector2Int(x, y));
        //entities[new Vector2Int(x, y)].SendMessage("OnCreated", new Vector2Int(x, y), SendMessageOptions.DontRequireReceiver);
    }

    //public void SetEntity(T tile)
    //{
    //    int x = Mathf.RoundToInt(tile.transform.position.x);
    //    int y = Mathf.RoundToInt(tile.transform.position.y);

    //    if (entities.ContainsKey(new Vector2Int(x, y)))
    //    {
    //        RemEntity(x, y);
    //    }

    //    entities[new Vector2Int(x, y)] = tile;

    //    tile.SendMessage("OnCreated", SendMessageOptions.DontRequireReceiver);
    //}

    public void Rem(int x, int y, int l)
    {
        if (entities.ContainsKey(new Vector3Int(x, y, l)))
        {
            //entities[new Vector2Int(x, y)].entity.Invoke(new NodeDeleted(entities[new Vector2Int(x, y)].id, x, y));
            entities[new Vector3Int(x, y, l)].node.InvokeDeleted<NodeData>(entities[new Vector3Int(x, y, l)]);
            entities.Remove(new Vector3Int(x, y, l));
        }
    }
}
