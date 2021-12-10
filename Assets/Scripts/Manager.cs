using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
  public Text text;

  private ItemList items;
  private bool[] found;

  void Start() {
    found = new bool[transform.childCount];
    text.text = $"Loaded {transform.childCount} items!";
  }

  void Update() {
    string ui = "Progress:\n";
    bool foundAll = true;
    for(int i = 0; i < transform.childCount; i++) {
      GameObject child = transform.GetChild(i).gameObject;
      if(!found[i]) found[i] = child.GetComponent<TrackingStateMonitor>().isTracked();
      if(foundAll) foundAll = found[i];
      string state = found[i] ? "Found!" : "Missing!";
      ui += $"\t{child.name}: {state}\n";
    }
    if(foundAll) ui = "Level Complete!";

    text.text = ui;
  }
}
