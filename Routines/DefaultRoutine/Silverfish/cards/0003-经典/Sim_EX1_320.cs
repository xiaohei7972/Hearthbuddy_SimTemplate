using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_320 : SimTemplate //* 末日灾祸 Bane of Doom
	{
		//Deal $2 damage to_a character. If that kills it, summon a random Demon.
		//对一个角色造成$2点伤害。如果“末日灾祸”消灭该角色，随机召唤一个恶魔。        
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_059);//bloodimp
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{


            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            bool summondemon = false;

            if (!target.isHero && dmg >= target.Hp && !target.divineshild && !target.immune)
            {
                summondemon = true;
            }

            p.minionGetDamageOrHeal(target, dmg);

            if (summondemon)
            {
                int posi = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                
                if (target.own && ownplay) p.callKid(kid, posi, ownplay);
                else p.callKid(kid, posi, ownplay);
            }

		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}