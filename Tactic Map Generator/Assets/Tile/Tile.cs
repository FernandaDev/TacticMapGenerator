using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] TileData tileData;

    int xCoord, yCoord;

    bool isWalkable;
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
