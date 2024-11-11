using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class displayNumObjects : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI objectNum;
    // Start is called before the first frame update
    
    void Start()
    {
        objectNum.text = "Objects Remaining: " + GameObject.FindGameObjectsWithTag("boat").Length.ToString();
        GameManager.Instance.NumObjects = GameObject.FindGameObjectsWithTag("boat").Length;
    }

    // Update is called once per frame
    private void Update()
    {
        objectNum.text = "Objects Remaining: " + GameManager.Instance.NumObjects;
    }
}
