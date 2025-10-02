using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：2 攻击力：3 生命值：2
	//Tenwu of the Red Smoke
	//“赤烟”腾武
	//<b>Battlecry:</b> Return a friendly minion to your hand. It costs (1) this turn.
	//<b>战吼：</b>将一个友方随从移回你的手牌，在本回合中，其法力值消耗为（1）点。
	class Sim_DMF_071 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.minionReturnToHand(target, target.own, (-target.handcard.card.cost + 1));
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
		
	}
}
