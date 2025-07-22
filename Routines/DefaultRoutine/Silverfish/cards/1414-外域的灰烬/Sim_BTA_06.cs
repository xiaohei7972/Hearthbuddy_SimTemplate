using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BTA_06 : SimTemplate //* 恶魔猎手斯克里布 Sklibb, Demon Hunter
	{
        //[x]Your other minionshave +2_Attack.<b>Outcast:</b> Summon three 1/1_Illidari with <b>Rush</b>.
        //你的其他随从获得+2攻击力。<b>流放：</b>召唤三个1/1并具有<b>突袭</b>的伊利达雷。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
        {
            if (outcast)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_037t), p.ownMinions.Count, true);
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_037t), p.ownMinions.Count, true);
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_037t), p.ownMinions.Count, true);
            }
        }

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 2, 0);
                }
            }
            else
            {
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 2, 0);
                }
            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -2, 0);
                }
            }
            else
            {
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -2, 0);
                }
            }
        }

    }
}
