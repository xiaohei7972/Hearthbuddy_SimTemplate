using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_040 : SimTemplate //* 南海岸酋长 South Coast Chieftain
	{
		//<b>Battlecry:</b> If you control another Murloc, deal 2_damage.
		//<b>战吼：</b>如果你控制另一个鱼人，则造成2点伤害。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if(target == null) return;
            bool foundMurloc = false;
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (((TAG_RACE)m.handcard.card.race == TAG_RACE.MURLOC || m.handcard.card.race == CardDB.Race.ALL) && m.entitiyID != own.entitiyID)
                {
                    foundMurloc = true;
                    break;
                }
            }
            if(foundMurloc){
                if (target.isHero) p.evaluatePenality += 1;
                if (target.Hp == 2) p.evaluatePenality -= 20;
                p.minionGetDamageOrHeal(target, 2);
            }
        }
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
