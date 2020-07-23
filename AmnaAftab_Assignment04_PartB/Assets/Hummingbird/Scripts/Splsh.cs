using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splsh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("load", 2);
    }

    void load()
    {
        SceneManager.LoadScene(1);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
