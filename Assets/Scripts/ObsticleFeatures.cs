using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleFeatures : MonoBehaviour
{
    private int volume = 1;
    protected string soundTrack;
   public virtual void MakerNoise()
    {
        Debug.Log("Playing noise track");
    }

    private void OnCollisionEnter(Collision collision)
    {
        MakerNoise();
    }
}
