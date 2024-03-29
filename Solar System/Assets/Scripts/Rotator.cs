using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    public float yawDegreePerSecond = 45f;
    public float eachPlanetSpeed;

    Transform earthTransform;
    // Start is called before the first frame update
    void Start() {
       
    }

    // Update is called once per frame
    void Update() {
        Transform myTransform = GetComponent<Transform>();
        myTransform.Rotate(new Vector3(0f, yawDegreePerSecond * Time.deltaTime * eachPlanetSpeed, 0f), Space.World);
    }
}
