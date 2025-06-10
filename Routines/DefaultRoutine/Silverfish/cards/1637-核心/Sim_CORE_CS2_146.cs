using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：1 攻击力：2 生命值：1
    //Southsea Deckhand
    //南海船工
    //Has <b>Charge</b> while you have a weapon equipped.
    //如果你装备着武器，本随从拥有<b>冲锋</b>。
    class Sim_CORE_CS2_146 : SimTemplate
    {
        public override void onAuraStarts(Playfield p, Minion m)
        {
            UpdateCharge(p, m);
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            m.charge = 0;
        }

        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == m.own)
            {
                UpdateCharge(p, m);
            }
        }

        private void UpdateCharge(Playfield p, Minion m)
        {
            // 使用统一的逻辑来更新冲锋状态
            bool hasWeaponEquipped = m.own ? p.ownWeapon.Durability >= 1 : p.enemyWeapon.Durability >= 1;
            m.charge = hasWeaponEquipped ? 1 : 0;
        }
    }
}
