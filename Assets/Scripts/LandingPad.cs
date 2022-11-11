using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LandingPad : MonoBehaviour
{
    public string LevelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player")) // is there a better way to do this?
            SceneManager.LoadScene(LevelToLoad);
    }
}
