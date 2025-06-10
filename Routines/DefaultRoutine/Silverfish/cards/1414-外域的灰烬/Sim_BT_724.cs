using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_724 : SimTemplate //* 虚灵改装师 Ethereal Augmerchant
	{
		//<b>Battlecry:</b> Deal 1 damage to a minion and give it <b>Spell Damage +1</b>.
		//<b>战吼：</b>对一个随从造成1点伤害并使其获得<b>法术伤害+1</b>。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				if (target.divineshild || (!target.own && target.Hp > 1)) p.evaluatePenality += 1000;
				p.minionGetDamageOrHeal(target, 1);
				if (target.Hp > 1) p.spellpower++;
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
