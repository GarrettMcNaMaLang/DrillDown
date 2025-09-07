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

    public bool upTop, inControl, ParachuteActive, BoosterActive;

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

            if (ParachuteActive)
            {
                 if (disruptorType == DisruptorType.Parachute)
                {
                    ParachuteMode();
                }
            }
           
            if (BoosterActive)
            {
                if (disruptorType == DisruptorType.Booster && BoosterActive)
                {
                     BoosterMode();
                }
            }
            
        }
        else
        {

            matt.color = Color.white;
        }

       
        
    }

    public void ParachuteMode()
    {
        Debug.Log("Parachute Mode");
        return;
        
    }

    public void BoosterMode()
    {
        Debug.Log("Booster Mode");
        return;
        
    }
}
