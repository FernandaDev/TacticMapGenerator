using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] TileData tileData;

    [SerializeField] [HideInInspector] int xCoord, yCoord;

    [SerializeField] [HideInInspector] bool isWalkable;
    public bool IsWalkable
    {
        get { return isWalkable; }
        set
        {
            isWalkable = value;
            SetMaterial(value);
        }
    }

    public void SetTileCoords(int x, int y)
    {
        xCoord = x;
        yCoord = y;
    }

    void SetMaterial(bool _isWalkable)
    {
        var renderer = GetComponentInChildren<Renderer>();
        renderer.sharedMaterial = _isWalkable ? tileData.WalkableMaterial : tileData.UnwalkableMaterial;
    }
}
