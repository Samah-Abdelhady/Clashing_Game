using UnityEngine;
//using System.Collections;

public class Credits : MonoBehaviour {

    public void Quit()
    {
        Debug.Log("QUITTING");
        Application.Quit();//that command wont work in unity but it will work when we export the game
    }
}
