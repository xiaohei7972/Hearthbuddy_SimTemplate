using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_539 : SimTemplate //* 杀戮命令 Kill Command
	{
		//Deal $3 damage. If you control a Beast, deal$5 damage instead.
		//造成$3点伤害。如果你控制一个野兽，则改为造成$5点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                bool haspet = false;
                foreach (Minion m in p.ownMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PET)
                    {
                        haspet = true;
                        break;
                    }
                }

                int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
                if (haspet) dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
                p.minionGetDamageOrHeal(target, dmg);
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