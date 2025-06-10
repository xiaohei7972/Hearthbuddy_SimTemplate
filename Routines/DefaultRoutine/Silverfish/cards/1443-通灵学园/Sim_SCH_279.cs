using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_279 : SimTemplate //* 引月长弓 Trueaim Crescent
	{
        //After your Hero attacks a minion, your minions attack it too.
        //在你的英雄攻击一个随从后，你的所有随从也会攻击该随从。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_279), true);
        }

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            if (target.isHero) return;
            foreach(Minion m in p.ownMinions)
            {
                if (target.Hp > 0)
                {
                    if (!m.untouchable && m.Angr >= target.Hp && !m.Ready
                        && !(target.handcard.card.nameCN == CardDB.cardNameCN.月牙))
                    {
                        p.evaluatePenality -= target.Hp * 4 - m.Hp * 4;
                        if (m.Angr == target.Hp) p.evaluatePenality -= 5;
                    }
                    p.minionAttacksMinion(m, target);
                }
            }
        }

    }
}
