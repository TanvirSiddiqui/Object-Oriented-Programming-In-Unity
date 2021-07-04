using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBarrier : ObsticleFeatures
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void MakerNoise()
    {
        Debug.Log("Playing Barrier sound track");
    }
}
