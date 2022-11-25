using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    // A SerializeField can be modified from Unity editor instead of doing it from the script every time
    [SerializeField]
    Transform transTarget;

    void Update()
    {
        transform.position = transTarget.position;
    }
}
