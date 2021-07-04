using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBus : MonoBehaviour
{
    public GameObject bus;
    Vector3 offset = new Vector3(0.00999999978f, 6.78999996f, -9.23999977f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Follow();
    }
    void Follow()
    {
        transform.position = bus.transform.position + offset;
    }
}