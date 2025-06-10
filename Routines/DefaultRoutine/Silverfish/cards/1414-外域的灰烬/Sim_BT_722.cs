using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_722 : SimTemplate //* 防护改装师 Guardian Augmerchant
	{
		//<b>Battlecry:</b> Deal 1 damage to a minion and give it <b>Divine Shield</b>.
		//<b>战吼：</b>对一个随从造成1点伤害并使其获得<b>圣盾</b>。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				if (target.divineshild || (!target.own && target.Hp > 1)) p.evaluatePenality += 1000;
				p.minionGetDamageOrHeal(target, 1);
				if (target.Hp > 0) target.divineshild = true;
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
