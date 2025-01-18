using UnityEngine;

public class Ice : MonoBehaviour
{
    private bool interactable = false;

    public SpriteRenderer hint;
    
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
            interactable = true;
            hint.gameObject.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.gameObject.name == "Player")
            interactable = false;
            hint.gameObject.SetActive(false);
    }
}
