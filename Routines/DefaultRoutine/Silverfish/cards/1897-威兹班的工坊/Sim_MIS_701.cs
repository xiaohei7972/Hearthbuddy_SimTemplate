using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：5
	//Wave of Nostalgia
	//恋旧风潮
	//Transform ALL minions into random <b>Legendary</b> ones from the past.
	//将所有随从变形成为来自过去的随机<b>传说</b>随从。
	class Sim_MIS_701 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{            
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp )
            {
                
                
                p.minionTransform(m, p.getRandomCardForManaMinion(m.handcard.card.cost + 6));
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
		
	}
}
