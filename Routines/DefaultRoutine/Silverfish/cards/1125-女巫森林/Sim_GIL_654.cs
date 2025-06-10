using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_654 : SimTemplate //战路
	{

		//    回响,对所有随从造成1点伤害。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int Smana = p.mana - 2;
			if (Smana >= 2) p.drawACard(CardDB.cardNameEN.warpath, ownplay);
			int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
			p.allMinionsGetDamage(dmg);

		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}