﻿using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace MutCommon.UnityAtoms
{
  public class WatchTransform : MonoBehaviour
  {
    public Vector3Variable Position;
    public Vector3Variable Rotation;
    public Vector3Variable Scale;

    // Update is called once per frame
    void Update()
    {
      Position?.SetValue(transform.position);
      Rotation?.SetValue(transform.rotation.eulerAngles);
      Scale?.SetValue(transform.localScale);
    }
  }
}