using UnityEngine.SceneManagement;
using UnityEngine;

public class Load : MonoBehaviour
{
    public void LoadScene(string �C���e��)
    {
        SceneManager.LoadScene(�C���e��);
    }
    public void Quit()
    {
        Application.Quit();
        print("�����C��");
    }
}
