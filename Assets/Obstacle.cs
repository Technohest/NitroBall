using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public float speed;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
	    other.GetComponent<Player>().isAlive = false;
	    Destroy(gameObject);
	} else if (other.CompareTag("Cleanup")) {
	    Destroy(gameObject);
	}
    }
    
    // Start is called before the first frame update
    void Start()
    {
	Debug.Log("onstart");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
