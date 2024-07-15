using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class Score : MonoBehaviour
{
    private int rings;
    public TextMeshProUGUI ringText;
    private void Start()
    {
        rings = 0;
        ringText.text = "Rings:" + rings.ToString();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ring"))
        {
            rings++;
            ringText.text = "Rings: " + rings.ToString();
            Destroy(other.gameObject); 
        }
    }
}
