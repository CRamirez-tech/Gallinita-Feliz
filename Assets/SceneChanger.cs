using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Cargador de Escenas");
    }

    public void LoadB(int sceneANumber)
    {
        Debug.Log("sceneBuildIndex to load: " + sceneANumber);
        SceneManager.LoadScene(sceneANumber);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
    }
}