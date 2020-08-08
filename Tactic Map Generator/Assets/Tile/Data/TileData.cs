using UnityEngine;

[CreateAssetMenu(fileName = "Tile Data", menuName = "ScriptableObjects/Tile Data")]
public class TileData : ScriptableObject
{
    [Header("Materials")]

    [SerializeField] Material walkableMaterial;
    public Material WalkableMaterial { get { return walkableMaterial; } }

    [SerializeField] Material unwalkableMaterial;
    public Material UnwalkableMaterial { get { return unwalkableMaterial; } }

}
