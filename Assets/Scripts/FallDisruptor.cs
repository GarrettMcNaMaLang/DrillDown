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

    private bool upTop, inControl;

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
