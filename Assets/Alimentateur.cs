using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alimentateur : MonoBehaviour
{
    private bool state = false;
    public GameObject energySource = null;

    public bool getState(){
    	return state;
    }

    public void setState(bool s){
    	state = s;
    }

    public void setEnergySource(GameObject energySource){
    	this.energySource=energySource;
    	setState(true);
    	Debug.Log("Yes");
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
