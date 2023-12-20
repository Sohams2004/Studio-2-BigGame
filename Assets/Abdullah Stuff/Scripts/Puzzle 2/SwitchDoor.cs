using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwitchDoor : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;
    [SerializeField] GameObject door;
    [SerializeField] GameEvent gameEvent;

    // Start is called before the first frame update
    // Update is called once per frame
    int counts;
        
   public void CountingButtons(int number)
            {

            if (counts <= buttons.Length && counts >=0 )
            {
                counts += number;
            Debug.Log("added" + number);
            }
            if (counts == buttons.Length)
        {
            Debug.Log("AND OPPPPEEEEEEN");
            gameEvent.Raise();

            gameObject.SetActive(false);
        }
            else
        {
            gameObject.SetActive(true);
        }


    }




}
