using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_024 : SimTemplate //* 希望圣契 Libram of Hope
	{
		//Restore 8 Health. Summon an 8/8 Guardian with <b>Taunt</b> and_<b>Divine Shield</b>.
		//恢复8点生命值。召唤一个8/8并具有<b>嘲讽</b>和<b>圣盾</b>的守卫。

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_024t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			//恢复8点生命值
			int heal = (ownplay) ? p.getSpellHeal(8) : p.getEnemySpellHeal(8);
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.minionGetDamageOrHeal(target, -heal);
            p.callKid(kid, pos, ownplay, false);
		}
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
