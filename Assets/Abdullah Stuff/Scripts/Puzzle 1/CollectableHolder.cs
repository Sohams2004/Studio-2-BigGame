using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableHolder : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<GameObject> collectableHolder= new List<GameObject>();
    [SerializeField] GameObject unlockDoor;
   public void CheckForUnactive()
    {

        for(int i = collectableHolder.Count-1; i>=0; i--)
        {
             if (collectableHolder[i].activeSelf == false)
            {
                if (i==0)
                {
                    Debug.Log("Null" + collectableHolder[i].name);
                    Destroy(collectableHolder[i]);
                    collectableHolder[i] = null;

                }

                else 
                { 
                Debug.Log("I removed" + collectableHolder[i].name);
                    Destroy(collectableHolder[i]);
                    collectableHolder.RemoveAt(i);
                }

            }
            if (collectableHolder[0] == null && collectableHolder.Count < 2)
            {
                unlockDoor.SetActive(false);
            
            }


        }


    }


}
