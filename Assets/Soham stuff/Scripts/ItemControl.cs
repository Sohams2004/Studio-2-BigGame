using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    [SerializeField] float throwForce;

    [SerializeField] Vector2 startDrag;

    [SerializeField] Rigidbody2D itemRb;

    [SerializeField] LineRenderer lineRenderer;

    private void Start()
    {
        itemRb = GetComponent<Rigidbody2D>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    void ThrowItem()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startDrag = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            
        }
    }

    private void Update()
    {
        ThrowItem();
    }
}
