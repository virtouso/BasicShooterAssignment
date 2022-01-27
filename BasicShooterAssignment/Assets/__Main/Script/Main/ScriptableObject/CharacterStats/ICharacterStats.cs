using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterStats 
{
  int CharacterDamageAbsolute { get;  }
  int WeaponDamageAbsolute { get;  }
  float CharacterUpgradePercentageModifier { get; }
  int AttackDamageAbsoluteModifier { get;  }
  float AttackDamagePercentModifier { get;  }
}
