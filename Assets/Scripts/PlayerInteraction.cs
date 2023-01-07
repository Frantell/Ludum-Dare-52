using UnityEngine;

public enum PlayerItemTypes {
    Empty,
    WaterCan,
    WheatSeed,
    CarrotSeed,
    BeetSeed
}

public class PlayerInteraction : MonoBehaviour {
    GameObject interactingWith;
    public PlayerItemTypes inventory;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Interactable")) {
            // set interaction flag to true
            interactingWith = other.gameObject;
        } else {
            interactingWith = null;
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Interactable")) {
            // turn off interaction flag
            interactingWith = null;
        }
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            if (interactingWith != null) {
                interactingWith.GetComponent<Interactable>().Interact();
            }
        }
    }

}