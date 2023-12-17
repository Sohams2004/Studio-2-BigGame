using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    public Material highlightMaterial;
    public Renderer selectedObjectBody;
    public GameObject player;

    Ray cameraRay;
    [SerializeField] Camera camera;
    public TextMeshProUGUI uiPressE;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        cameraRay = camera.ScreenPointToRay(Input.mousePosition);
        Vector3 currentDistance = transform.position - player.transform.position ;
        if (currentDistance.magnitude < 10)
        {

            Physics.Raycast(cameraRay, out RaycastHit hitInfo, 12 ,~8, QueryTriggerInteraction.Ignore);
            if (gameObject.name != hitInfo.transform.gameObject.name)
            {
                uiPressE.enabled = false;
                var mat = selectedObjectBody.sharedMaterials;
                mat[1] = null;
                selectedObjectBody.sharedMaterials = mat;
            }
            else if (gameObject.name == hitInfo.transform.gameObject.name)
            {
                uiPressE.enabled = true;

                var mat = selectedObjectBody.sharedMaterials;
                mat[1] = highlightMaterial;
                selectedObjectBody.sharedMaterials = mat;


            }

        }
        else {
            uiPressE.enabled = false;
            var mat = selectedObjectBody.sharedMaterials;
            mat[1] = null;
            selectedObjectBody.sharedMaterials = mat;

        }

    }

}
