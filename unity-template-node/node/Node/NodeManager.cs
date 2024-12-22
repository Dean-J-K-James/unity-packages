/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */
public class NodeManager : Singleton<NodeManager>
{
    Dictionary<Vector2Int, Node> map = new();

    public Node Get(int x, int y)           { var p = new Vector2Int(x, y); return map.ContainsKey(p) ? map[p] : null; }
    public void Set(string e, int x, int y) { var p = new Vector2Int(x, y); Rem(x, y); map[p] = Asset.INSTANCE.Get<Node>(e); map[p].InvokeCreated(p); }
    public void Rem(int x, int y)           { var p = new Vector2Int(x, y); if (map.ContainsKey(p)) { map[p].InvokeDeleted(p); map.Remove(p); } }
}
