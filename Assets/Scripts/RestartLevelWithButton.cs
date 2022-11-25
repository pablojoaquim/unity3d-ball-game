using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelWithButton : MonoBehaviour
{
    // A SerializeField can be modified from Unity editor instead of doing it from the script every time
    [SerializeField]
    KeyCode keyRestart;

    void Update()
    {
        if(Input.GetKey(keyRestart))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
