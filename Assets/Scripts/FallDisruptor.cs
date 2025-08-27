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

    bool upTop;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
