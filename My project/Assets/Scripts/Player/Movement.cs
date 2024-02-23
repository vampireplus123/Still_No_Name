using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        // float ver = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hor,0,0);
        movement.Normalize();
        transform.Translate(movement*speed*Time.deltaTime,Space.World);
        
        if(movement != Vector3.zero){
            transform.forward = movement;
            Quaternion toRotate = Quaternion.LookRotation(movement,Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation,toRotate,rotateSpeed*Time.deltaTime);
        }

    }
}
