using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        if(SceneManager.GetActiveScene().name == "level4")
        {
            Invoke("Credits",restartDelay+1);
        }
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Game Over");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
