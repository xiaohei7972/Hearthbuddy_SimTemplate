using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //法术 萨满祭司 费用：4
    //Digging Straight Down
    //向下深挖
    //Deal $8 damageto a minion.<b>Excavate</b> a treasure.
    //对一个随从造成$8点伤害。<b>发掘</b>一个宝藏。
    class Sim_DEEP_009 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                // 造成8点伤害
                int dmg = ownplay ? p.getSpellDamageDamage(8) : p.getEnemySpellDamageDamage(8);
                p.minionGetDamageOrHeal(target, dmg);

                // 发掘一个宝藏
                CardDB.Card treasure = p.handleExcavation();
                p.drawACard(treasure.cardIDenum, ownplay, true);
            }
        }

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				// new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
			};
		}
    }
}
