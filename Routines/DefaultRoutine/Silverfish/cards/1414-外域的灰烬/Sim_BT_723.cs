using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_723 : SimTemplate //* 火箭改装师 Rocket Augmerchant
	{
		//<b>Battlecry:</b> Deal 1 damage to a minion and give it <b>Rush</b>.
		//<b>战吼：</b>对一个随从造成1点伤害并使其获得<b>突袭</b>。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				if (target.divineshild || (!target.own && target.Hp > 1)) p.evaluatePenality += 1000;
				p.minionGetDamageOrHeal(target, 1);
				if (target.Hp > 1) p.minionGetRush(own);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
