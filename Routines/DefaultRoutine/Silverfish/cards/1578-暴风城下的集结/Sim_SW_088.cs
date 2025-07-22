using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_088 : SimTemplate //* 恶魔来袭 Demonic Assault
	{
		//[x]Deal $3 damage.Summon two 1/3Voidwalkers with <b>Taunt</b>.
		//造成$3点伤害。召唤两个1/3并具有<b>嘲讽</b>的虚空行者。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_065);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
    		int dmg =  p.getSpellDamageDamage(3) ;
            p.minionGetDamageOrHeal(target, dmg);
			int pos = p.ownMinions.Count;
			p.callKid(kid, pos + 1, ownplay);
			p.callKid(kid, pos + 1, ownplay);
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
			};
		}
	}
}
