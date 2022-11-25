using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
    // A SerializeField can be modified from Unity editor instead of doing it from the script every time
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;

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
        if(Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity +=  v3Force;
        if(Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -=  v3Force;

    }
}
