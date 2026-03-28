using UnityEngine;
using UnityEngine.SceneManagement;

public class Goplay : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Lv.1");
    }
}