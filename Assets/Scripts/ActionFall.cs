
using UnityEngine;

public class ActionFall : MonoBehaviour {
    private void Awake()
    {
        this.enabled = false;
    }
    private void OnEnable()
    {
        gameObject.AddComponent<Rigidbody2D>();
        gameObject.AddComponent<BoxCollider2D>();
        gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
    }

}
