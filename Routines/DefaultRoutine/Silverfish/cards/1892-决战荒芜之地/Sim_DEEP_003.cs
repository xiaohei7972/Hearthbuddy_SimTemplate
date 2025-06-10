using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：1
	//Shimmer Shot
	//磷光射击
	//Deal $1 damage. Summon a random minion of that Cost.
	//造成$1点伤害，随机召唤一个法力值消耗与伤害量相同的随从。
	class Sim_DEEP_003 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 计算实际伤害
            int dmg = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);

            // 对目标造成伤害
            p.minionGetDamageOrHeal(target, dmg);

            // 使用 Playfield 的方法获取一个随机的同法力值消耗的随从
            CardDB.Card randomMinion = p.getRandomCardForManaMinion(dmg);

            // 如果找到有效的随从卡牌，则召唤该随从
            if (randomMinion != null)
            {
                p.callKid(randomMinion, p.ownMinions.Count, ownplay);
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
