using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballConroller : MonoBehaviour
{
    private Rigidbody rb;
    public float upwardForce;
    public float forwardForce;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * upwardForce + Vector3.forward * forwardForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
