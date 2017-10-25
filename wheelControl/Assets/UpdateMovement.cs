using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMovement : MonoBehaviour {

    public Camera Camera_1;
    public Camera Camera_2;
    // Update is called once per frame
    void Update() {
        transform.position += transform.up * Time.deltaTime * 0.2f;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Finish"))
        {
            Camera_1.gameObject.SetActive(false);
            Camera_2.gameObject.SetActive(true);

        }
    }
}

