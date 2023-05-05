using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class TwstAsync : MonoBehaviour
{


    private CancellationTokenSource _source= new CancellationTokenSource();
    async void StartOperation(CancellationToken token)
    {
        Debug.Log("operation start");
        await Task.Delay(1000,token);
        Debug.Log("first running");
        await Task.Delay(1000,token);
        Debug.Log("second running");
        await Task.Delay(1000,token);
        Debug.Log("third running");
        await Task.Delay(1000,token);
        Debug.Log("fourth running");
        await Task.Delay(1000,token);
        Debug.Log("fifth running");
    }


    private void Start()
    {
        
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            _source = new CancellationTokenSource();
         StartOperation(_source.Token);   
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _source.Cancel();
        }
    }
}
