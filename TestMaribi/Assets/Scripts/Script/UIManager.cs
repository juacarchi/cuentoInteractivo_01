using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Image imageFade;
    public bool isCorrectVolume = true;
    public static UIManager instance;
    public float speedFade;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void StartFadeImageToBlack(int sceneToLoad)
    {
        StartCoroutine(FadeImageToBlack(sceneToLoad));
    }
    public void StartFadeImageToTransparent()
    {
        StartCoroutine(FadeImageToTransparent());
    }
    public IEnumerator FadeImageToBlack(int sceneToLoad)
    {
        imageFade.enabled = true;

        for (float i = 0; i < 1; i += Time.deltaTime * speedFade)
        {
            imageFade.color = new Color(0, 0, 0, i);
            if (SoundManager.instance.GetVolume() > 0.08f && !isCorrectVolume)
            {
                SoundManager.instance.SetVolume(SoundManager.instance.GetVolume() - i);
            }
            else { isCorrectVolume = true; }
            yield return null;
        }
        imageFade.color = new Color(0, 0, 0, 1);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine("FadeImageToTransparent");
        SceneManager.LoadScene(sceneToLoad);
    }
    public IEnumerator FadeImageToTransparent()
    {
        for (float i = 1; i > 0; i -= Time.deltaTime * speedFade)
        {
            imageFade.color = new Color(0, 0, 0, i);

            yield return null;
        }
        imageFade.color = new Color(0, 0, 0, 0);
        yield return new WaitForSeconds(1);
    }
}
