using UnityEngine;
//using System.Collections;

public class playerMovement : MonoBehaviour
{

    public Rigidbody Rb;
    //create variables
    public float forwardForce = 700f;
    public float sidewaysForce = 500f;
    // Use this for initialization

    void Start()
    {
        // Debug.Log("hello");//debug.log()is used for print messages
        // Rb.useGravity = false;//for make the shape not controlled by gravity
        // Rb.AddForce(0, 200, 500);//for making the shape moving under forces in x,y,z axes
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);//in this case if i delete startfunction the object will continue moving too 
        //Time.deltaTime is multiplied to make the object move in the same speed in every computer or system

        //if statement
        if (Input.GetKey("d"))
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//ForceMode.VelocityChange ==>makes the object ignores its mass
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
       
        if(Rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
