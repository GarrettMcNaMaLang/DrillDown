using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class BlockScript : MonoBehaviour
{

    public GameObject blockObject;

    bool left, right, grounded;

    [SerializeField]
    public List<FallDisruptor> TopDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> LeftDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> RightDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> BottomDisruptors = new List<FallDisruptor>();


    public enum CurrDisruptors
    {
        Up,
        Down,
        Left,
        Right
    }

    public CurrDisruptors currDisruptors;


    void RotateBlock(float value)
    {
        if (grounded == true)
            return;


        blockObject.transform.Rotate(new Vector3(0, 0, value));
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (grounded)
            StationaryMode();

        if (Input.GetKeyDown(KeyCode.A))
        {
            RotateBlock(-90);


        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            RotateBlock(90);
        }



        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SendCommand(TopDisruptors);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SendCommand(BottomDisruptors);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SendCommand(LeftDisruptors);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SendCommand(RightDisruptors);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Debug.Log("Block is on Ground");
            grounded = true;
        }
    }


    void StationaryMode()
    {

    }

    void SendCommand(List<FallDisruptor> TurnOn)
    {
        foreach (FallDisruptor dis in TurnOn)
        {
            dis.inControl = true;
        }
    }

    void TurnOff(CurrDisruptors TurnOff)
    {

    }

    //functions to turn on and off each Disruptor List
}
