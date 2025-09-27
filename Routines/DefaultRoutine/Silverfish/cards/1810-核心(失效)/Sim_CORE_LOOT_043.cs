using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：4
	//Lesser Amethyst Spellstone
	//小型法术紫水晶
	//<b>Lifesteal.</b> Deal $3 damage to a minion. <i>(Take damage from your cards to upgrade.)</i>
	//<b>吸血</b>对一个随从造成$3点伤害。<i>（受到来自你的卡牌的伤害后升级。）</i>
	class Sim_CORE_LOOT_043 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                int damage = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
                p.minionGetDamageOrHeal(target, damage);
                p.applySpellLifesteal(damage, ownplay);
            }
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
