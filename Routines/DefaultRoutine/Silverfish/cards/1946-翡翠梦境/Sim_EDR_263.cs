using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：4
	//Grace of the Greatwolf
	//巨狼的恩赐
	//[x]<b>Choose One -</b> Deal $4damage to the enemyhero; or Summon two3/2 Wolves with <b>Rush</b>.
	//<b>抉择：</b>对敌方英雄造成$4点伤害；或者召唤两只3/2并具有<b>突袭</b>的狼。
	class Sim_EDR_263 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_850pe);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int damage = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
				p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, damage);
			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay);
				p.callKid(kid, pos, ownplay);
			}
		}
		
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 2) //确保有位置召唤
            };
        }
		
	}
}
