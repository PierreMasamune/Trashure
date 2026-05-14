using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject target;
    void TurnOff()
    {
        target.SetActive(false);
    }
    void TurnOn()
    {
        target.SetActive(true);
    }
}

