using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInteraction : InteractionBehaviour {

    public override void Activate() {
        Destroy(gameObject);
    }
}
