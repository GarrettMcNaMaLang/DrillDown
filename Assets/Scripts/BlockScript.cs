using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{

    public GameObject blockObject;

    bool left, right;

    [SerializeField]
    public List<FallDisruptor> TopDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> LeftDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> RightDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> BottomDisruptors = new List<FallDisruptor>();


    void RotateBlock(float value)
    {
        blockObject.transform.Rotate(new Vector3(0, 0, value));
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            RotateBlock(-90);


        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            RotateBlock(90);
        }
    }
}
