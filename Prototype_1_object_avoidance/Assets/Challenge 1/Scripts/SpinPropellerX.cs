using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{

    public float rotationSpeed = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(0, 0, rotationSpeed );
    }
}
