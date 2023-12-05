using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level2GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hintText;

    private void Start()
    {
        StartCoroutine(HintText());
    }

    IEnumerator HintText()
    {
        hintText.enabled = true;
        yield return new WaitForSeconds(5);
        hintText.enabled = false;
    }
}
