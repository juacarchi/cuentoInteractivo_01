using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class MoveUI : MonoBehaviour, IDragHandler, IDropHandler

{
    SpriteRenderer fuego1;
    SpriteRenderer fuego2;
    SpriteRenderer fuego3;
    Image vaso;
    float alpha1 = 1;
    float alpha2 = 1;
    float alpha3 = 1;
    public float velocityFade;
    public float zValue = 1;
    RectTransform rectGO;
    bool isFuego1;

    private void Awake()
    {
        velocityFade = 0.5f;
        rectGO = GetComponent<RectTransform>();
        vaso = GetComponent<Image>();
    }

    public void OnDrag(PointerEventData eventData)
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = zValue;
        Vector3 point = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = point;


    }

    public void OnDrop(PointerEventData eventData)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WaterLake"))
        {
            LlenaAgua(this.gameObject);
            SFXManager.instance.PlaySFX(SFXManager.instance.soundCorrect);
        }


        if (other.CompareTag("Fuego1"))
        {
            fuego1 = other.GetComponent<SpriteRenderer>();
            Destroy(this.gameObject, 1.5f);
            Collider2D collider = GetComponent<Collider2D>();
            Destroy(collider);
            GameManager.instance.ApagaLlama();
            SFXManager.instance.PlaySFX(SFXManager.instance.soundCorrect);
        }
        else if (other.CompareTag("Fuego2"))
        {
            fuego2 = other.GetComponent<SpriteRenderer>();
            Destroy(this.gameObject, 1.5f);
            Collider2D collider = GetComponent<Collider2D>();
            Destroy(collider);
            GameManager.instance.ApagaLlama();
            SFXManager.instance.PlaySFX(SFXManager.instance.soundCorrect);
        }
        else if (other.CompareTag("Fuego3"))
        {
            fuego3 = other.GetComponent<SpriteRenderer>();
            Destroy(this.gameObject, 1.5f);
            Collider2D collider = GetComponent<Collider2D>();
            Destroy(collider);
            GameManager.instance.ApagaLlama();
            SFXManager.instance.PlaySFX(SFXManager.instance.soundCorrect);
        }

    }
    private void Update()
    {
        if (fuego1 != null)
        {
            if (fuego1.color.a > -0.1f)
            {
                Destroy(fuego1.gameObject, 1.5f);
                alpha1 -= Time.deltaTime * velocityFade;
                fuego1.color = new Color(1, 1, 1, alpha1);
                vaso.color = new Color(1, 1, 1, alpha1);
            }


        }
        else if (fuego2 != null)
        {
            if (fuego2.color.a > 0)
            {
                Destroy(fuego2.gameObject, 1.5f);
                alpha2 -= Time.deltaTime * velocityFade;
                fuego2.color = new Color(1, 1, 1, alpha2);
                vaso.color = new Color(1, 1, 1, alpha2);
            }

        }
        else if (fuego3 != null)
        {
            if (fuego3.color.a > 0)
            {
                Destroy(fuego3.gameObject, 1.5f);
                alpha3 -= Time.deltaTime * velocityFade;
                fuego3.color = new Color(1, 1, 1, alpha3);
                vaso.color = new Color(1, 1, 1, alpha3);
            }

        }
    }

    public void LlenaAgua(GameObject go)
    {
        Image imageVaso = GetComponent<Image>();
        imageVaso.sprite = GameManager.instance.vasoLleno;
        Collider2D collider = go.GetComponent<Collider2D>();
        collider.enabled = false;
        GameManager.instance.LlenaVaso();
    }
}

