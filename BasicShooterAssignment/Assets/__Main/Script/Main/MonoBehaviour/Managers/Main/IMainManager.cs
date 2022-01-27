using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMainManager
{
 IEnemy GetEnemy(Transform transform);
 IUpgradeDrop GetDrop(Transform transform);
 void DisplayMessage(string message,Vector3 referenceEntityPosition);
}
