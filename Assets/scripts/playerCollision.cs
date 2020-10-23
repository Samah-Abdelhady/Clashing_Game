using UnityEngine;
//using System.Collections;

public class playerCollision : MonoBehaviour
{

    // Use this for initialization
    public playerMovement movement;
  //  public GameManager gameManager;
    /*	void Start () {

        }

        // Update is called once per frame
        void Update () {

        }*/

    private void OnCollisionEnter(Collision collisionInfo)
    {
        // Debug.Log("i hit something");
        // Debug.Log(collisionInfo.collider.name);
        /* if(collisionInfo.collider.name=="obstical")
          {
              Debug.Log("i hit obstical");
          }*/

        if (collisionInfo.collider.tag == "obstical")
        {
            // Debug.Log("i hit obstical");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
