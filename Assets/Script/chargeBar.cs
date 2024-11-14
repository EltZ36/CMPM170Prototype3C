using UnityEngine;
using UnityEngine.UI;
using System;

public class chargeBar : MonoBehaviour
{

    Vector3 startPos;
    Vector3 endPos;
    [SerializeField]
    private Image bar;
    private bool mouseDown = false;
    private const int MAX_DISTANCE = 200;
    private float degrees = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0 ) && isBoatClick()){
            OnMouseDown();
        } else if (Input.GetMouseButtonUp(0)){
            OnMouseUp();
        }

        if(mouseDown){
            // emit event with difference between startpos x and z and currentpos x and z
            endPos.x = -Input.mousePosition.y;
            endPos.z = Input.mousePosition.x;
            float distance = Vector3.Distance(startPos, endPos);
            float fillPercentage = Mathf.Clamp01(distance / MAX_DISTANCE); 
            Debug.Log($"Distance: {distance}, Fill: {fillPercentage}");
            bar.fillAmount = fillPercentage;
            OnMouseHold();
            // if(distance > MAX_DISTANCE){
            //     Debug.Log("MAX DIST");
            //     bar.fillAmount = 100f;
            //     // set the fill bar to full
            // }
            // else {
            //     Debug.Log(fillPercentage);
            //     bar.fillAmount = fillPercentage;
            // }
        }
        // bar.fillAmount += Time.deltaTime * 0.1f; // Gradually fills over time
    }

    private bool isBoatClick(){
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("boat"))
            {
                Debug.Log("Hit object with tag: " + hit.collider.gameObject.name);
                return true;
            }
        }
        return false;
    }
    private void OnMouseDown()
    {
        Debug.Log("click");
        mouseDown = true;
        startPos.x = -Input.mousePosition.y;
        startPos.z = Input.mousePosition.x;
        bar.rectTransform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
    }

    private void OnMouseHold()
    {
        if(Input.mousePosition.x > bar.rectTransform.position.x)
        {
            degrees = (float)(Math.Atan((Input.mousePosition.y - bar.rectTransform.position.y) / (Input.mousePosition.x - bar.rectTransform.position.x)) * (180 / Math.PI)) - 90f;
        } else
        {
            degrees = 180f + (float)(Math.Atan((Input.mousePosition.y - bar.rectTransform.position.y) / (Input.mousePosition.x - bar.rectTransform.position.x)) * (180 / Math.PI)) - 90f;
        }
        bar.rectTransform.eulerAngles = new Vector3(0f, 0f, degrees);
    }

      private void OnMouseUp()
    {   
        mouseDown = false;
        endPos.x = -Input.mousePosition.y;
        endPos.z = Input.mousePosition.x;
        bar.fillAmount = 0f;  // Reset fill amount when released
    }
}
