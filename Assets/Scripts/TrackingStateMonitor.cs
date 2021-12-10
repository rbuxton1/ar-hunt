using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackingStateMonitor : MonoBehaviour {
  private bool tracked = false;

  public void onTrackingFound() { tracked = true; }
  public void onTracingLost() { tracked = false; }

  public bool isTracked() { return tracked; }
}
