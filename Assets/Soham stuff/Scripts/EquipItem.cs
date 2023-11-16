using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class EquipItem : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] Rigidbody2D itemRb;

    //[SerializeField] Transform itemDetect;
    [SerializeField] Transform itemHold;

    [SerializeField] float radius;

    [SerializeField] bool isSelected;
    [SerializeField] bool isItem;

    private void Start()
    {
        //item.SetActive(false);
    }

    void Selectitem()
    {
        if(Input.GetKeyUp(KeyCode.Alpha2) && !isSelected)
        {
            Debug.Log("Item selected");
            item.SetActive(true);
            isSelected = true;
        }

        else if (Input.GetKeyUp(KeyCode.Alpha2) && isSelected)
        {
            item.SetActive(false);
            isSelected = false;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Item"))
        {
            isItem = true;
        }

        if (isItem)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("Collected");
                //item = GameObject.FindWithTag("Item");
                item.gameObject.transform.parent = itemHold.transform;
            }
        }
    }

    /*void DetectItem()
    {
        var itemCheck = Physics2D.OverlapCircleAll(itemDetect.position, radius)
    }*/

    private void OnCollisionExit2D(Collision2D other)
    {
        isItem = false;
    }

    private void Update()
    {
        Selectitem();
    }
}
