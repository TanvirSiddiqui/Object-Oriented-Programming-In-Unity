using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : Trasportation
{
    [SerializeField] float speed = 20f;
    [SerializeField] float horizontalSpeed = 5f;
    float horizontalInput;
    float forwardInput;
    public MeshCollider busMeshCol;
    int counter = 0;



   
    public void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalSpeed * horizontalInput);
    }

    public void MakeSuperBus()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            busMeshCol.isTrigger = true;
            StartCoroutine(TPrint());
        }
    }

    IEnumerator TPrint()
    {
        
        yield return new WaitForSeconds(counter);
        Debug.LogError("After "+counter+" seconds");
        counter++;
    }
}
