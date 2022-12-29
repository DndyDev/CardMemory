using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;

    public Color highlightColor = Color.cyan;

    public void OnMouseEnter()
    {
       SetButtonColor(highlightColor);
    }

    public void OnMouseExit()
    {
        SetButtonColor(Color.white);
    }

    private void SetButtonColor(Color color)
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = color;
        }
    }

    public void OnMouseDown()
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    public void OnMouseUp()
    {
        transform.localScale = Vector3.one;
        if(targetObject != null) {
            targetObject.SendMessage(targetMessage);
        }
    }
}
