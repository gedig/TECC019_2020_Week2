using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOnTrigger : MonoBehaviour
{
    public string winSceneName = "WinScene";

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            SceneManager.LoadScene(winSceneName);
        }
    }
}
