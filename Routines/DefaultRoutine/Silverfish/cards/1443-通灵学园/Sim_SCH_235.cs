using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_235 : SimTemplate //* 衰变飞弹 Devolving Missiles
	{
        //[x]Shoot three missilesat random enemy minionsthat transform them intoones that cost (1) less.
        //随机向敌方随从发射三枚飞弹，使其变形成为法力值消耗减少（1）点的随从。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int cnt = 3;
            foreach(Minion m in p.enemyMinions)
            {
                if(cnt > 0)
                {
                    int cost = m.handcard.card.cost;
                    cost = cost - 1 <= 0 ? 1 : cost - 1;
                    p.minionTransform(m, CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_tk1));
                    m.Hp = m.Angr = m.maxHp = cost;
                    cnt--;
                }
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (cnt > 0)
                {
                    int cost = m.handcard.card.cost;
                    cost = cost - 1 <= 0 ? 1 : cost - 1;
                    p.minionTransform(m, CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_tk1));
                    m.Hp = m.Angr = m.maxHp = cost;
                    cnt--;
                }
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (cnt > 0)
                {
                    int cost = m.handcard.card.cost;
                    cost = cost - 1 <= 0 ? 1 : cost - 1;
                    p.minionTransform(m, CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_tk1));
                    m.Hp = m.Angr = m.maxHp = cost;
                    cnt--;
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
    }
}
