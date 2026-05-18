using UnityEngine;

public class FixIt : MonoBehaviour
{
    public GameObject prefab;
    public void Change()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
