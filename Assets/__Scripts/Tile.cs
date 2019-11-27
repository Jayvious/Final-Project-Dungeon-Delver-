using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [Header("Set Dynamically")]
    public int x;
    public int y;
    public int tileNum;
    
    public void SetTile(int eX, int eY, int eTileName = -1)
    {
        x = eX;
        y = eY;
        transform.localPosition = new Vector3(x, y, 0);
        gameObject.name = x.ToString("D3") + "X" + y.ToString("D3");

        if(eTileName == -1)
        {
            eTileName = TileCamera.GET_MAP(x, y);
        }

        tileNum = eTileName;
        GetComponent<SpriteRenderer>().sprite = TileCamera.SPRITES[tileNum];
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
