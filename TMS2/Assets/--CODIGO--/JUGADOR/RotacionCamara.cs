﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionCamara : MonoBehaviour
{   
    private GameObject myGameObj;
    private GameObject mycam;
    public int altura=5;
    public int velocidad;
    private Camera myCamComponent;
    void Start()
        {
            myGameObj= GameObject.Find("PATO");
            mycam= gameObject.transform.GetChild(0).gameObject;
            myCamComponent= mycam.GetComponent<Camera>();
            this.transform.position= myGameObj.transform.position+new Vector3(0,altura,0);
        }
    void Update()
    {   

            /*
            if(cosa==null)
                {
                    mycam.transform.RotateAround(myGameObj.transform.position, this.transform.up,Input.GetAxis("Mouse X")*speed);
                    mycam.transform.LookAt(myGameObj.transform);

                }
                else
                    {
                        mycam.transform.RotateAround(cosa.transform.position, this.transform.up,Input.GetAxis("Mouse X")*speed);
                        mycam.transform.LookAt(cosa.transform);
                        
                    }

*/          

            mycam.transform.LookAt(myGameObj.transform.position);


            if(Input.GetAxis("Mouse ScrollWheel") < 0)
                {
                            mycam.transform.Translate(-Vector3.forward *velocidad* Time.deltaTime, Space.Self);
                }

            if(Input.GetAxis("Mouse ScrollWheel") > 0)
                {
                    
                            mycam.transform.Translate(Vector3.forward *velocidad* Time.deltaTime, Space.Self);
                }



    }

}
