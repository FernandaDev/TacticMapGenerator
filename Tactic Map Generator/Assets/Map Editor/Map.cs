using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    private static Map instance;
    public static Map Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<Map>();
                if ( instance == null)
                {
                    instance = new GameObject("Map").AddComponent<Map>();
                }
            }

            return instance;
        }
    }

    public List<GameObject> tilesList = new List<GameObject>();
}
