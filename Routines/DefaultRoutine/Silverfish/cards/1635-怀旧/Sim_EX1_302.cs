using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_302 : SimTemplate //* 死亡缠绕 Mortal Coil
	{
		//Deal $1 damage to a minion. If that kills it, draw a card.
		//对一个随从造成$1点伤害。如果“死亡缠绕”消灭该随从，抽一张牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            if (dmg >= target.Hp && !target.divineshild && !target.immune)
            {
                //this.owncarddraw++;
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
            p.minionGetDamageOrHeal(target, dmg);
            
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}