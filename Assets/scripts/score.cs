using UnityEngine;
using UnityEngine.UI;
//using System.Collections;

public class score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    // Use this for initialization
    /*	void Start () {

        }*/

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position.z);
        scoreText.text = player.position.z.ToString("0");//i write this 0 to make the numbers appear as ingteger not float

    }
}
