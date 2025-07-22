using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_307 : SimTemplate //* 圣光闪现 Flash of Light
//Restore #4 Health.Draw a card.
//恢复#4点生命值。抽一张牌。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = (ownplay) ? p.getSpellHeal(4) : p.getEnemySpellHeal(4);
            p.minionGetDamageOrHeal(target, -heal);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}