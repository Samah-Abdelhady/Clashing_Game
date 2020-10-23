using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour
{

    // Use this for initialization
    public Transform player;
    public Vector3 offset;//that variable is used for control the position of the camera a way from player object
                          /*void Start () {

                          }*/

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position);
        // transform.position = player.position;
        /*transform with t small letter mains the main camera's transform.position
          as that followPlayer class is follower of main camera
         and the problem here is in this case the camera will follow the center of player object so that it will be shown
         as personal seen (as a man is inside the cube and looking out which means that the camera is inside the object)*/

        transform.position = player.position + offset;//add offset make that even if the object rotate the camera still the same

    }
}
