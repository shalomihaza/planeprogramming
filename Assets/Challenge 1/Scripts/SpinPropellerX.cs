using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{

    private float spinSpeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // spin propeller object round the z axis
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);

    }
}
