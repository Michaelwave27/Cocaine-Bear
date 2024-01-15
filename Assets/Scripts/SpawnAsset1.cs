using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class AssetSpawner : MonoBehaviour
{
    public Transform _theAsset;
    public Vector3 _spawnPosition;

    //Call this.Spawn() from Start() or Update() or whereever your logic triggers the spawn of the asset
    void Spawn()
    {
        Transform instanciatedAsset;

        instanciatedAsset = (Transform)Instantiate(this._theAsset, this._spawnPosition, Quaternion.identity);
        //Do stuff with your instanciatedAsset ...
    }
}
