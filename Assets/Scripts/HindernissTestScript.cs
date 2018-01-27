using UnityEngine;

public class HindernissTestScript : MonoBehaviour {
    public bool deactivated = false;
    public Transform backPosition;
    public float moveBackSpeed = 32f;
    void Update()
    {
        if (deactivated == true)
        {
            Vector3 velocity = transform.position - backPosition.position;
            velocity = velocity.normalized;
            if (Vector3.Distance(transform.position, backPosition.position) > 1.0f)
            {
                transform.position -= velocity * moveBackSpeed * Time.deltaTime;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                deactivated = true;
            }
        }
    }
}
