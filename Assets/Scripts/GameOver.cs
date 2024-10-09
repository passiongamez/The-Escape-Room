using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
   Canvas _canvas;
   [SerializeField] Button _close;
    [SerializeField] Button _restart;
    [SerializeField] TMPro.TextMeshProUGUI _youEscaped;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "XR Origin")
        {
            _youEscaped.gameObject.SetActive(true);
            _close.gameObject.SetActive(true);
            _restart.gameObject.SetActive(true);
        }
    }
}
