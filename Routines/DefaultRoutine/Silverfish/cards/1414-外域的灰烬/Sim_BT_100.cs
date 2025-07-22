using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_100 : SimTemplate //* 毒蛇神殿传送门 Serpentshrine Portal
	{
		//Deal $3 damage.Summon a random3-Cost minion.<b>Overload:</b> (1)
		//造成$3点伤害。随机召唤一个法力值消耗为（3）的随从。<b>过载：</b>（1）
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
			p.minionGetDamageOrHeal(target, dmg);
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(p.getRandomCardForManaMinion(3), pos, ownplay);
			if (ownplay) p.ueberladung++;
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
