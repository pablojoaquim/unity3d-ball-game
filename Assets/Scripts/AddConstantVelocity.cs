using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    // A SerializeField can be modified from Unity editor instead of doing it from the script every time
    [SerializeField]
    Vector3 v3Force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update at a fixed rate (i.e. 100times/sec)
    void FixedUpdate()
    {
        // GetComponent<Rigidbody>().velocity +=  new Vector3(0.1f,0 ,0);
        GetComponent<Rigidbody>().velocity +=  v3Force;
    }
}
