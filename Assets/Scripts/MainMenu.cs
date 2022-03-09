using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public Text highscore_num;

    private void Start()
    {
        highscore_num.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
        Debug.Log("what the hell");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
