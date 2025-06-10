using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：4 攻击力：3 生命值：3
    //Dang-Blasted Elemental
    //炸裂元素
    //<b>Taunt</b><b>Deathrattle:</b> Deal 2 damageto all minions exceptfriendly Elementals.
    //<b>嘲讽</b>。<b>亡语：</b>对除友方元素外的所有随从造成2点伤害。
    class Sim_WW_397 : SimTemplate
    {
        public override void onDeathrattle(Playfield p, Minion m)
        {
            List<int> MinionentitiyID = new List<int>();
            foreach (Minion m in p.ownMinions)
            {
                if (m.handcard.card.reac == 18)
                {
                    MinionentitiyID.Add(m.entitiyID);
                }
            }
			MinionentitiyID.
            p.allMinionsGetDamage(2, MinionentitiyID);
        }

    }
}
