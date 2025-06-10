using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_072 : SimTemplate //* 飞天鱼人 Skyfin
	{
        //<b>Battlecry:</b> If you're holding a Dragon, summon 2 random Murlocs.
        //<b>战吼：</b>如果你的手牌中有龙牌，随机召唤两个鱼人。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            bool foundDragon = false;
            foreach(Handmanager.Handcard hc in p.owncards)
            {
                if(hc.card.race == CardDB.Race.DRAGON || hc.card.race == CardDB.Race.ALL)
                {
                    foundDragon = true;
                }
            }
            if (foundDragon)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_072), own.zonepos - 1, true);
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_072), own.zonepos, true);
            }
        }

    }
}
