using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void CharacterSelect()
    {
        SceneManager.LoadScene("Character Select", LoadSceneMode.Single);
    }

    public void IntroScene()
    {
        SceneManager.LoadScene("Intro", LoadSceneMode.Single);
    }

    public void SettingsScene()
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Additive);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit(); 
    }
}