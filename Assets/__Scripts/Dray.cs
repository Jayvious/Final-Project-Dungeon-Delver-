using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dray : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float speed = 5;

    [Header("Set Dynamically")]
    public int dirHeld = -1;

    private Rigidbody rigid;

    private Vector3[] directions = new Vector3[]
    { Vector3.right, Vector3.up, Vector3.left, Vector3.down};


     void Awake()
    {
        rigid = GetComponent<Rigidbody>();
         
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirHeld = -1;
        if (Input.GetKey(KeyCode.RightArrow)) dirHeld = 0;
        if (Input.GetKey(KeyCode.UpArrow)) dirHeld = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) dirHeld = 2;
        if (Input.GetKey(KeyCode.DownArrow)) dirHeld = 3;

        Vector3 vel = Vector3.zero;
        if (dirHeld > -1) vel = directions[dirHeld];

        rigid.velocity = vel * speed;
    }
}
