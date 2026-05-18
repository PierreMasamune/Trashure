using UnityEngine;

public class BuyingMenu : MonoBehaviour
{
    public bool yes;
    private void OnMouseDown()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)&&yes==true)
        {
            GetComponentInParent<BuildingScript>().Buy();
            GetComponentInParent<FixIt>().Change();

        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && yes == false)
        {
            GetComponentInParent<BuildingScript>().NoBuy();

        }
    }
}
