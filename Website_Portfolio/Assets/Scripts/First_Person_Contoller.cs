using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class First_Person_Contoller : MonoBehaviour
{
    // Start is called before the first frame update

    public CharacterController Controller;
    public float speed = 12f;
    public float gravity = -9.81f;

    private Vector3 velocity;
    
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * x + transform.forward * z);

        Controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity*Time.deltaTime;

        Controller.Move(velocity * Time.deltaTime);

    }
}
