using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTriggerScript : MonoBehaviour {

    BoxCollider2D boxCollider;
    SpriteRenderer spriteRenderer;

    private void Awake() {
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //private void OnCollisionEnter2D(Collision2D collision) {
    //    if (collision.gameObject.CompareTag("Player")) {

    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("Player")) {
            Debug.Log("The player has gone through the trigger");
            Debug.LogWarning("Warning!!!");
            collision.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            //collision.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f);
        }

        //if (collision.GetComponent<CircleCollider2D>()) {
        //    Debug.Log("This thing has a circle collider component");
        //}

    }
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            Debug.Log("The player has gone through the trigger");
            //Debug.LogError("ERROR!!!");
            collision.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

    }




}
