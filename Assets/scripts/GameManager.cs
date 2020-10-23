using UnityEngine;
using UnityEngine.SceneManagement;//we used that when we want to reload the same scene or use a different scene

public class GameManager : MonoBehaviour
{
    public bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        //Debug.Log("Level WON!");
        completeLevelUI.SetActive(true);//this make the statement level complete appear
    }
    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over");
        }
        //Restart();
        Invoke("Restart", restartDelay);//this for making the restartlevel stay aspecific time before restating
    }
    public void Restart()
    {
        //SceneManager.LoadScene("level1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//this is equal to the upper statement but that is bestin case we have multible scenes
       
    }
}
