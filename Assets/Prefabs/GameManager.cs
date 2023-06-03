using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    public float restartDeplay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("We won");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDeplay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
