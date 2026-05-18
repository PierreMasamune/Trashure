using UnityEngine;

public class ToggleUI : MonoBehaviour
{
    public CanvasGroup MenuToggled;
    public void TurnOff()
    {
        MenuToggled.alpha = 0f;
        MenuToggled.interactable = false;
        MenuToggled.blocksRaycasts = false;
    }
    public void TurnOn()
    {
        MenuToggled.alpha = 1f;
        MenuToggled.interactable = true;
        MenuToggled.blocksRaycasts = true;
    }
}