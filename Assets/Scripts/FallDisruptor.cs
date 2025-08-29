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
    

    void OnEnable()
    {
        
    }

    void OnDisable()
    {
        
    }

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (disruptorType == DisruptorType.Parachute && Input.GetKeyDown(KeyCode.UpArrow))
        {
            ParachuteMode();
        }

        if (disruptorType == DisruptorType.Booster && Input.GetKeyDown(KeyCode.DownArrow))
        {
            BoosterMode();
        }

        if (disruptorType == DisruptorType.Booster && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BoosterMode();
        }
        
         if (disruptorType == DisruptorType.Booster && Input.GetKeyDown(KeyCode.RightArrow))
        {
            BoosterMode();
        }
    }

    bool ParachuteMode()
    {
        return false;
    }

    bool BoosterMode()
    {
        return false;
    }
}
