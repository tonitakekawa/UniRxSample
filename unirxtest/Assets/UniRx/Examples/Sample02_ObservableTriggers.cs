using System;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class Sample02_ObservableTriggers : MonoBehaviour
{
    void Start()
    {
        this.UpdateAsObservable()
            .SampleFrame(120)
            .Subscribe(_ => Debug.Log("hoge"));
    }
}
