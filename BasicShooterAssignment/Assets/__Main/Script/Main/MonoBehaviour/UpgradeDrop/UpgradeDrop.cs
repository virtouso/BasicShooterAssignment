
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class UpgradeDrop:MonoBehaviour,IUpgradeDrop
    {
        [SerializeField] private StatModifierTypeBase _statModifier;
        public StatModifierTypeBase StatModifier => _statModifier;
        public void Consume()
        {
            StartCoroutine(DisableDelayed());
        }
        
        private IEnumerator DisableDelayed()
        {
            yield return new WaitForSeconds(1f);
            gameObject.SetActive(false);
        }
    }
