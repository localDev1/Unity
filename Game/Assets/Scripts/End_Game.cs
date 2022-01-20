using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Game : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Sphere")
        {

            SceneManager.LoadScene(2);
        }
    }
}
