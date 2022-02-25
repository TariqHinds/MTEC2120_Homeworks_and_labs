using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("rubber chicken");  
        
    }
    // Update is called once per frame
    void Update(){
        Ray myRay = new Ray(transform.position, transform.forward);
        RaycastHit rayHit;
        if(Input.GetKeyDown(KeyCode.A)){
            Debug.Log("You pressed the 'a' key"); 
        }
            if (!Physics.Raycast(myRay, out rayHit, Mathf.Infinity))
            {
                Debug.Log("Raycast distance is" + rayHit.distance); 
            }
        }
    }
    
    




