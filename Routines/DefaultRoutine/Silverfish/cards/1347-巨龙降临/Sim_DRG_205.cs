using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_205 : SimTemplate //* 虚空吐息 Nether Breath
	{
		//Deal $2 damage.If you're holding a Dragon, deal $4 damage with <b>Lifesteal</b> instead.
		//造成$2点伤害。如果你的手牌中有龙牌，则改为造成$4点伤害并具有<b>吸血</b>。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
			p.minionGetDamageOrHeal(target, dmg);
		}


		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
