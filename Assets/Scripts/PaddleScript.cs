using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    //private float speed;
    // public float speed;

    void OnMouseDrag()
        {
            Vector3 objectPointInScreen
                = Camera.main.WorldToScreenPoint(this.transform.position);

            Vector3 mousePointInScreen
                = new Vector3(Input.mousePosition.x,
                            objectPointInScreen.y,
                            objectPointInScreen.z);
            
            Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
            mousePointInWorld.z = this.transform.position.z;
            mousePointInWorld.y = this.transform.position.y;
            this.transform.position = mousePointInWorld;
        }
    // // Start is called before the first frame update
    // void Start()
    // {
    //     //speed = 5f;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);
    //     Debug.Log(transform.position.x);
    // }
}

