using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_010 : SimTemplate //* 暴躁的牧羊人 Ram Wrangler
//<b>Battlecry:</b> If you have a Beast, summon arandom Beast.
//<b>战吼：</b>如果你控制任何野兽，则随机召唤一个野兽。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PET)
                {
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_120), temp.Count, own.own);
                    break;
                }
            }
        }
    }
}