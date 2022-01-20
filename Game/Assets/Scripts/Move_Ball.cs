using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Ball : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody rigb;
    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHoriz, 0.0f, moveVert);
        rigb.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            print("Your lose!!");
            SceneManager.LoadScene(1);
        }
        if (collision.gameObject.tag == "Goal")
        {
            print("Your Win!!");
            SceneManager.LoadScene(2);
        }
    }

        
    
    
}
