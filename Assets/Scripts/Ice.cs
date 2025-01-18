using UnityEngine;

public class Ice : MonoBehaviour
{
    private bool interactable = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "Player")
            inner.gameObject.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.gameObject.name == "Player")
            inner.gameObject.SetActive(false);
    }
}
