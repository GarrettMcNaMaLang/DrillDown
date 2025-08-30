using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FallDisruptor : MonoBehaviour
{
    public enum DisruptorType
    {
        Parachute,
        Booster
    }

    public DisruptorType disruptorType;

    public bool upTop, inControl;

    SpriteRenderer matt;
    void OnEnable()
    {
        
    }

    void OnDisable()
    {
        
    }

    void Awake()
    {
        matt = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (inControl)
        {
            Debug.Log("In Control");
            matt.color = Color.red;
            if (disruptorType == DisruptorType.Parachute)
            {
                ParachuteMode();
            }

            if (disruptorType == DisruptorType.Booster)
            {
                BoosterMode();
            }
        }
        else
        {

            matt.color = Color.white;
        }

       
        
    }

    bool ParachuteMode()
    {
        Debug.Log("Parachute Mode");
        return false;
    }

    bool BoosterMode()
    {
        Debug.Log("Booster Mode");
        return false;
    }
}
