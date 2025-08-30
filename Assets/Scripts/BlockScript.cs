using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class BlockScript : MonoBehaviour
{

    public float weight = 40.0f;
    public GameObject blockObject;

    bool left, right, grounded;

    public Rigidbody2D rb;

    [SerializeField]
    public List<FallDisruptor> TopDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> LeftDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> RightDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> BottomDisruptors = new List<FallDisruptor>();

    List<FallDisruptor> CurrDisruptors = null;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void RotateBlock(float value)
    {
        if (grounded == true)
            return;


        blockObject.transform.Rotate(new Vector3(0, 0, value));
    }


    // Start is called before the first frame update
    void Start()
    {
        SendCommand(TopDisruptors);


    }

    // Update is called once per frame
    void Update()
    {

        if (grounded)
            StationaryMode();

        if (Input.GetKeyDown(KeyCode.Space) && CurrDisruptors != null)
        {
            ActivateDisruptors(CurrDisruptors);
        }

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

    void FixedUpdate()
    {

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
        if (CurrDisruptors == null)
            CurrDisruptors = TurnOn;

        Debug.Log("Changing Block");
        foreach (FallDisruptor dis in TurnOn)
        {

            dis.inControl = true;
        }
        TurnOff(CurrDisruptors);

        CurrDisruptors = TurnOn;
    }

    void TurnOff(List<FallDisruptor> turnOff)
    {
        if (turnOff == null)
            Debug.Log("Empty List");

        foreach (FallDisruptor dis in turnOff)
        {
            Debug.Log("Turning Off Block");
            dis.inControl = false;
        }
    }

    void ActivateDisruptors(List<FallDisruptor> Activate)
    {
        foreach (FallDisruptor active in Activate)
        {
            
        }
    }

    //functions to turn on and off each Disruptor List
}
