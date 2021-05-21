using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LlenarVaso : MonoBehaviour
{
    public Image imageButton;
    public Sprite spriteInicial;
    public Sprite spriteFinal;
    public SpriteRenderer showImage;
    public SpriteRenderer fuego;
    float alpha = 1;
    bool apagaFuego;
    public float velocityFade;
    public void LLenaVaso()
    {
        showImage.sprite = spriteFinal;
        if (imageButton != null)
        {
            imageButton.enabled = false;
        }
        
    }
    public void ApagaFuego()
    {
        apagaFuego = true;
    }
    private void Update()
    {
        if(apagaFuego && fuego.color.a > 0)
        {
            alpha -= velocityFade*Time.deltaTime;
            fuego.color = new Color(1, 1, 1, alpha);
        }
    }
}
