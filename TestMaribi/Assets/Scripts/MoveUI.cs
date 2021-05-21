using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MoveUI : MonoBehaviour, IDragHandler, IDropHandler

{

    public float zValue = 1;
    RectTransform rectGO;
   

    private void Awake()
    {
        
        rectGO = GetComponent<RectTransform>();

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
        
        Debug.Log("Suelta");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Llena vaso");
    }
}

