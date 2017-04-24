using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacerScript : MonoBehaviour {

    public void Placer()
    {
        gameObject.transform.position.Set(new_x: -396.0f, new_y:313f, new_z:0f);
    }

}
