using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Settings : MonoBehaviour
{
    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void Reset()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Resolution()
    {
        TMPro.TMP_Dropdown drop = GetComponentInChildren<TMPro.TMP_Dropdown>();

        if (drop.value == 0)
        {
            Screen.SetResolution(1440, 2560, true);
        }

        else if (drop.value == 1)
        {
            Screen.SetResolution(1080, 1920, true);
        }

        else if (drop.value == 2)
        {
            Screen.SetResolution(720, 1280, true);
        }

        else if (drop.value == 1)
        {
            Screen.SetResolution(600, 800, true);
        }
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene(SceneManager.sceneCount);
    }
}
