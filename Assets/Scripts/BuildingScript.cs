using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    public GameObject button;
    public ToggleVisibility menuToggle;
    private bool menu=false;

    public int cost;
    private void Awake()
    {
        if (menuToggle.MenuToggled == null)
        {
            menuToggle.MenuToggled = GameObject.FindGameObjectWithTag("CraftingMenu");
        }
    }
    private void Start()
    {
        button.SetActive(false);
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            button.SetActive(true);
            menu = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            button.SetActive(false);
            menu = false;
            menuToggle.TurnOff();
        }
    }
    private void Update()
    {
        if (menu && Input.GetKeyDown(KeyCode.E))
        {
            menuToggle.TurnOn();
        }
        else if (menu && Input.GetKeyDown(KeyCode.Escape))
        {
            menuToggle.TurnOff();
        }
    }
    public void Buy()
    {
        PlayerStats.Instance.RemoveCash(cost);
        menuToggle.TurnOff();
    }
    public void NoBuy()
    {
        menuToggle.TurnOff();
    }
}
