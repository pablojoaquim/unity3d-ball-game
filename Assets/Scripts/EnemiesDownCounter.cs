using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDownCounter : MonoBehaviour
{
    private int cnt;

    [SerializeField]
    string strTag;

    // Start is called before the first frame update
    void Start()
    {
        cnt = 0;  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == strTag)
            cnt++;
    }
}
