using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswitch : MonoBehaviour {
	public Camera Camera_1;
    private void Start()
    {
        Camera_1.gameObject.SetActive(true);
    }


}
