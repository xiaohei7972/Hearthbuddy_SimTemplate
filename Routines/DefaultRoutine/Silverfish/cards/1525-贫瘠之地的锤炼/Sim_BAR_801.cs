using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_801 : SimTemplate //* 击伤猎物 Wound Prey
	{
		//Deal $1 damage. Summon a 1/1 Hyena with <b>Rush</b>.
		//造成$1点伤害。召唤一只1/1并具有<b>突袭</b>的土狼。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (null == target) return;
			int dmg = p.getSpellDamageDamage(1) ;
            p.minionGetDamageOrHeal(target, dmg);
			if(p.ownMinions.Count > 6)
            {
				p.evaluatePenality += 10;
            }
			p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_035t), p.ownMinions.Count, true);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
