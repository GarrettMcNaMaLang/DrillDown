using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    [SerializeField]
    public List<FallDisruptor> TopDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> LeftDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> RightDisruptors = new List<FallDisruptor>();
    [SerializeField]
    public List<FallDisruptor> BottomDisruptors = new List<FallDisruptor>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
