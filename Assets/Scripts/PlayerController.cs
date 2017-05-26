using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int direction=0;
    public List<GameObject> listPortal = new List<GameObject>();

    void Update()
    {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Translate(0, 0, z);
        if(x < 0 )
        {
            Debug.Log("left");
            Quaternion newRotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            newRotation *= Quaternion.Euler(0, -90, 0);
            transform.rotation = Quaternion.Lerp(this.transform.rotation, newRotation, 1  * Time.deltaTime);
            direction = 0;
        }
        else if(x > 0)
        {
            Debug.Log("right");
            Quaternion newRotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            newRotation *= Quaternion.Euler(0, 90, 0);
            transform.rotation = Quaternion.Lerp(this.transform.rotation, newRotation, 1 * Time.deltaTime);
            direction = 1;
        }
        else if(z < 0 && direction != 2)
        {
            transform.Rotate(0, -180, 0);
            direction = 2;
        }
        else if(z > 0 && direction != 3)
        {
            transform.Rotate(0, 0, 0);
            direction = 3;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Portal")
        {
            Debug.Log("masuk");
            Debug.Log(transform.position);
            if(other.transform == listPortal[0].transform)
            {
                Debug.Log("from 0 to 1");
                transform.position = new Vector3(listPortal[1].transform.position.x, gameObject.transform.position.y, listPortal[1].transform.position.z);
            }
            else
            {
                Debug.Log("from 1 to 0");
                transform.position = new Vector3(listPortal[0].transform.position.x, gameObject.transform.position.y, listPortal[0].transform.position.z);
            }
            
            Debug.Log(transform.position);
        }
    }
    
}