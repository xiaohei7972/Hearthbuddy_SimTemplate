using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_317 : SimTemplate //* 古墓卫士 Catacomb Guard
	{
		//[x]<b>Lifesteal</b><b>Battlecry:</b> Deal damageequal to this minion's Attackto an enemy minion.
		//<b>吸血</b>，<b>战吼：</b>对一个敌方随从造成等同于该随从攻击力的伤害。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target == null) return;
			int dmg = own.Angr;
			p.minionGetDamageOrHeal(target, dmg);
			p.minionGetDamageOrHeal(p.ownHero, -dmg);

		}

		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
