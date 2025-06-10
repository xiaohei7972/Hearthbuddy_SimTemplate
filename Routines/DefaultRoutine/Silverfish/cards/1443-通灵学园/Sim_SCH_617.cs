using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_617 : SimTemplate //* 萌物来袭 Adorable Infestation
	{
		//Give a minion +1/+1. Summon a 1/1 Cub. Add a Cub to your hand.
		//使一个随从获得+1/+1。召唤一个1/1的魔鼠宝宝。将一张魔鼠宝宝置入你的手牌。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_617t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)//卡牌使用
        {
			if(target!=null)
		    {
		       p.minionGetBuffed(target, 1, 1);
               p.callKid(kid, p.owncards.Count, ownplay);     
	   		   p.drawACard(CardDB.cardIDEnum.SCH_617t, ownplay, true);
			}
        }
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
