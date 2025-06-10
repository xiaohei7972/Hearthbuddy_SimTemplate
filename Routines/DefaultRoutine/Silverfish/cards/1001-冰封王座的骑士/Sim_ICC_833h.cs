using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_833h: SimTemplate //* 冰冷触摸 Icy Touch
//<b>Hero Power</b> Deal $1 damage. If this kills a minion, summon a Water Elemental.
//<b>英雄技能</b>造成$1点伤害。如果该英雄技能消灭了一个随从，则召唤一个水元素。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_033); 

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(1) : p.getEnemyHeroPowerDamage(1);
            p.minionGetDamageOrHeal(target, dmg);

            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (target.Hp <= 0) p.callKid(kid, place, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}