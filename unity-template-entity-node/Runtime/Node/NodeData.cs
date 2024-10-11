/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

/**
 * 
 */
public class NodeData : EntityData
{
	public readonly Node node; //
	public readonly int x; //
	public readonly int y; //

	/**
	 * 
	 */
	public NodeData(Node node, int x, int y) : base()
	{
		this.node = node;
		this.x = x;
		this.y = y;
	}
}