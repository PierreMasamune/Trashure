using UnityEngine;

public class ToggleVisibility: MonoBehaviour 
{ 
    public GameObject MenuToggled; 
    public void TurnOff() 
    { 
        MenuToggled.SetActive(false); 
    } 
    public void TurnOn() 
    { 
        MenuToggled.SetActive(true); 
    } 
}

