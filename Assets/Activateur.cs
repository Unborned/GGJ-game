using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activateur : MonoBehaviour
{
	public Alimentateur alimentateur=null;
    void Start()
    {
        if(alimentateur!=null){
        	Debug.Log(alimentateur.getState());
        }
    }

    void Update()
    {
        
    }
}
