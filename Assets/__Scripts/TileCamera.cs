using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCamera : MonoBehaviour
{
    static private int W, H;
    static private int[,] MAP;
    static public Sprite[] SPRITES;
    static public Transform TILE_ANCHOR;
    static public Tile[,] TILES;

    [Header("Set in Inscpector")]
    public TextAsset mapData;
    public Texture2D mapTiles;
    public TextAsset mapCollisions; //this will be used later
    public Tile tilePrefab;

     void Awake()
    {
        LoadMap();  
    }

    public void LoadMap()
    {
        GameObject go = new GameObject("TILE_ANCHOR");
        TILE_ANCHOR = go.transform;

        SPRITES = Resources.LoadAll<Sprite>(mapTiles.name);

        string[] lines = mapData.text.Split('\n');
        H = lines.Length;
        string[] tileNums = lines[0].Split(' ');
        W = tileNums.Length;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
