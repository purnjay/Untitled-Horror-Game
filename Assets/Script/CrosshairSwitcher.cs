using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CrosshairSwitcher : MonoBehaviour {
    // list of available crosshair images
    public List<Sprite> crosshairs;
    // the onscreen image to replace
    public Image crosshairImage;

    // Sets a new crosshair image using the specified index.
    public void SetImage(int index) {
        if(index < crosshairs.Count)
            crosshairImage.sprite = crosshairs[index];
    }
}
