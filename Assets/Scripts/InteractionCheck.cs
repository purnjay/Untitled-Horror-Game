using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCheck : MonoBehaviour {
    [SerializeField]
    float distance = 5.0f;
    [SerializeField]
    Transform eyes;
    [SerializeField]
    LayerMask layerMask;

    // Update is called once per frame
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Activate();
        }
    }
    public void Activate() {
        if (eyes != null) {
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(eyes.position, eyes.forward, out hit, distance, layerMask)) {
                ObjectInfo info = hit.collider.GetComponent<ObjectInfo>();
                if (info) {
                    info.Activate();
                }
            }
        }
    }
}
