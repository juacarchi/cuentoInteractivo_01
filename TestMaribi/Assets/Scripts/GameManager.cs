using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject canvasVictory;
    public static GameManager instance;
    public Sprite vasoLleno;
    public Sprite vasoVacio;
    public int vasosLLenos;
    public int llamasApagadas;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        if (canvasVictory != null)
        {
            canvasVictory.SetActive(false);
        }

    }
    private void Update()
    {
        if (llamasApagadas == 3)
        {
            Debug.Log("Victoria");
            llamasApagadas = 0;
            canvasVictory.SetActive(true);
            SFXManager.instance.PlaySFX(SFXManager.instance.soundVictory);
        }
    }
    public void LlenaVaso()
    {
        vasosLLenos++;
    }
    public void ApagaLlama()
    {
        llamasApagadas++;
    }
}
