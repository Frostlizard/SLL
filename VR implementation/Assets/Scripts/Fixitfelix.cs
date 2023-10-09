using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixitfelix : MonoBehaviour, IDataPersistence
{
    public int collectCount;
    public DataPersistenceManager save;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        collectCount = collectCount + 100;
    }
    public void LoadData(GameData data)
    {
        this.collectCount = data.collectCount;
    }

    public void SaveData(ref GameData data)
    {
        data.collectCount = this.collectCount;
    }
}
