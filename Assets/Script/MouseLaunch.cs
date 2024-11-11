using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI; 

public class MouseLaunch : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 startPos;
    Vector3 endPos;
    Vector3 forceVector;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(mouseDown){
        //     // emit event with difference between startpos x and z and currentpos x and z
        //     endPos.x = -Input.mousePosition.y;
        //     endPos.z = Input.mousePosition.x;
        //     float distance = Vector3.Distance(startPos, endPos);
        //     float fillPercentage = distance / MAX_DISTANCE * 100;
        //     if(distance > MAX_DISTANCE){
        //         Debug.Log("MAX DIST");
        //         chargeBar.fillAmount = 100f;
        //         // set the fill bar to full
        //     }
        //     else {
        //         Debug.Log(fillPercentage);
        //         chargeBar.fillAmount = fillPercentage;
        //     }
        // }
        // chargeBar.fillAmount += Time.deltaTime * 0.1f; // Gradually fills over time
    }

    private void OnMouseDown()
    {
        // mouseDown = true;
        startPos.x = -Input.mousePosition.y;
        startPos.z = Input.mousePosition.x;
    }

    private void OnMouseUp()
    {   
        // mouseDown = false;
        endPos.x = -Input.mousePosition.y;
        endPos.z = Input.mousePosition.x;
        // Debug.Log(startPos + " " + endPos);
        forceVector = (startPos - endPos) * 0.5f;
        // Debug.Log(forceVector);

        m_Rigidbody.AddForce(forceVector, ForceMode.Impulse);
    }
}
