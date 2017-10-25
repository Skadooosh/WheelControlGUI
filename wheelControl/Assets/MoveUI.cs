using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveUI : MonoBehaviour {

    public static float x;
    public static float y;
    public GameObject Player;
    float z_rotation;
    
    private void Start()
    {
         x = this.gameObject.GetComponent<RectTransform>().position.x;
         y = this.gameObject.GetComponent<RectTransform>().position.y;
        z_rotation = this.gameObject.GetComponent<RectTransform>().rotation.z;
        
    }

    public void OnPointerDown()
    {
        // Get Angle in Radians
    	checkAngle();

    }
    public void checkAngle() {
        float AngleRad = Mathf.Atan2(y - Input.mousePosition.y, x - Input.mousePosition.x);
        // Get Angle in Degrees
        float AngleDeg = (180 / Mathf.PI) * AngleRad;
        
            z_rotation = AngleDeg + 90;
            this.transform.rotation = Quaternion.Euler(0, 0, z_rotation);
            Player.transform.rotation = Quaternion.Euler(0, 0, z_rotation);
        
       

    }
    public void OnDrag()
    {
        List<RaycastResult> RayResult = new List<RaycastResult>();
        PointerEventData pdata = new PointerEventData(EventSystem.current);
        pdata.position = Input.mousePosition;

        EventSystem.current.RaycastAll(pdata, RayResult);

        if (RayResult.Count == 0)
        {
            OnEndDrag();
        }

        else if (RayResult[0].gameObject.CompareTag("Wheel"))
        {
                checkAngle();
        }
      
    }
   

    public void OnEndDrag()
    {
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
        z_rotation = 0;
    }



}
