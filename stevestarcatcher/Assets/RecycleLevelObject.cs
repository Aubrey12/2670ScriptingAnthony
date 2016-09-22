using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
//gives us access to lists

public class RecycleLevelObject : MonoBehaviour {

	private Vector3 newLocation;
    public List<Recycler> recycleableList;
    private int i = 0;

    void Start()
    {
        recycleableList = new List<Recycler>();
        Recycler.RecycleAction += RecycleActionHandler;
    }

    private void RecycleActionHandler(Recycler _r)
    {
        recycleableList.Add(_r);
    }

    void OnTriggerEnter()
	{
		newLocation.x = StaticVars.nextSectionPosition;
		recycleableList[i].cube.position = newLocation;
		StaticVars.nextSectionPosition += StaticVars.distance;
        if (i < recycleableList.Count-1)
            i++;

	}

}
