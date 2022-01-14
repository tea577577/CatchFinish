using UnityEngine.SceneManagement;
using UnityEngine;

public class Load : MonoBehaviour
{
    public void LoadScene(string 遊戲畫面)
    {
        SceneManager.LoadScene(遊戲畫面);
    }
    public void Quit()
    {
        Application.Quit();
        print("關閉遊戲");
    }
}
