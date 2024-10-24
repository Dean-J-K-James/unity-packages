/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using UnityEngine;

/**
 * 
 */
public class BiomeCreateChunks : MonoBehaviour, IComponent, ICreated<BiomeData>
{
    public int chunks_x; //
    public int chunks_y; //

    /**
     * 
     */
    public void OnCreated(BiomeData bd)
    {
        for (int x = 0; x < chunks_x; x++)
            for (int y = 0; y < chunks_y; y++)
            {
                var chunkData = new ChunkData(Asset.INSTANCE.Get<Chunk>("chunk"), bd.biome, x, y);
                chunkData.chunk.InvokeCreated(chunkData);
            }
    }
}