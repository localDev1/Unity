using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    public SceneLoader sceneLoader;
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Sphere")
        {
            sceneLoader.LoadNextScene();
        }
    }
}
