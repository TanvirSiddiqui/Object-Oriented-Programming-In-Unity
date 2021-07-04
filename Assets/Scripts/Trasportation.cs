using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trasportation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 20f;
    [SerializeField] float horizontalSpeed = 5f;
    float horizontalInput;
    float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    public void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalSpeed * horizontalInput);
    }
}
