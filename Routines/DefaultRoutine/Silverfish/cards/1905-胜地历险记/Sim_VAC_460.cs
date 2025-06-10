using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：2
	//Oh, Manager!
	//把经理叫来！
	//Deal $2 damage.<b>Combo:</b> Get a coin.
	//造成$2点伤害。<b>连击：</b>获取一张幸运币。
	class Sim_VAC_460 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            // 对目标造成2点伤害
            p.minionGetDamageOrHeal(target, damage);

            // 如果触发连击效果
            if (p.cardsPlayedThisTurn >= 1)
            {
                p.drawACard(CardDB.cardIDEnum.GAME_005, ownplay, true); // 获取一张幸运币
            }
        }
    }
}
