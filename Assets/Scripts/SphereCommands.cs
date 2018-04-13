using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCommands : MonoBehaviour {

    Vector3 originalPosition;

    private void Start()
    {
        originalPosition = this.transform.localPosition;
    }

    void OnSelect() {
        if (!this.GetComponent<Rigidbody>())
        {
            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }
    }

    void OnReset() {
        var rigidbody = this.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            rigidbody.isKinematic = true;
            Destroy(rigidbody);
        }

        this.transform.localPosition = originalPosition;
    }

    void OnDrop()
    {
        OnSelect();
    }
}
