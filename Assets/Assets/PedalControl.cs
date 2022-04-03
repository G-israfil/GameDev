using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalControl : MonoBehaviour
{
    [SerializeField] float ekranGenisligiUnitCinsinden = 16f;
    [SerializeField] float xMin = 1.0f; 
    [SerializeField] float xMax = 15f;
    // Use this for initialization
    void Start () {
    }
    // Update is called once per frame
    void Update () {

        float farePozUnitCinsinden = Input.mousePosition.x / Screen.width * ekranGenisligiUnitCinsinden;
        float xMousePos = Mathf.Clamp(farePozUnitCinsinden, xMin, xMax);
        Vector2 pedalPozisyonu = new Vector2(farePozUnitCinsinden, transform.position.y);
        transform.position = pedalPozisyonu;
    }
}
