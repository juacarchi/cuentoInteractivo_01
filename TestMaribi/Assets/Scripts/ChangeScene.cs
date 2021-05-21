using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangeScene : MonoBehaviour
{
    Button buttonPressed;
    public void SetScene(int sceneToLoad)
    {
        buttonPressed = GetComponent<Button>();
        buttonPressed.interactable = false;
        SceneManager.LoadScene(sceneToLoad);
        
    }
}
