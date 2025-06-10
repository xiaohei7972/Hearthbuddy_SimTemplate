using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：3
	//Celestial Shot
	//星体射击
	//Deal $3 damage.Your next spell has <b>Spell Damage +2</b>.
	//造成$3点伤害。你的下一个法术拥有<b>法术伤害+2</b>。
	class Sim_YOG_082 : SimTemplate
	{
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
		
	}
}
